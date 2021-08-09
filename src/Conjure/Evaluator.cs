using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Conjure
{
    public class Evaluator
    {
        // This code is _*heavily*_ based on EFG:
        //    https://github.com/loresoft/EntityFrameworkCore.Generator/

        public delegate bool TryGetValue<K, V>(K key, out V V);

        public static string Eval(string variableOrText, IDictionary<string, string> variables) =>
            Eval(variableOrText, variables.TryGetValue);

        public static string Eval(string variableOrText, TryGetValue<string, string> lookup) =>
            Eval(variableOrText, lookup, new HashSet<string>(StringComparer.OrdinalIgnoreCase));

        private static string Eval(string variableOrText, TryGetValue<string, string> lookup, ISet<string> loop)
        {
            var result = new StringBuilder(variableOrText.Length * 2);
            var variable = new StringBuilder();
            var state = State.OutsideExpression;

            using (var reader = new StringReader(variableOrText))
            {
                do
                {
                    int c = -1;
                    switch (state)
                    {
                        case State.OutsideExpression:
                            c = reader.Read();
                            switch (c)
                            {
                                case -1:
                                    state = State.End;
                                    break;
                                case '{':
                                    state = State.OnOpenBracket;
                                    break;
                                case '}':
                                    state = State.OnCloseBracket;
                                    break;
                                default:
                                    result.Append((char) c);
                                    break;
                            }

                            break;
                        case State.OnOpenBracket:
                            c = reader.Read();
                            switch (c)
                            {
                                case -1:
                                    throw new FormatException();
                                case '{':
                                    result.Append('{');
                                    state = State.OutsideExpression;
                                    break;
                                default:
                                    variable.Append((char) c);
                                    state = State.InsideExpression;
                                    break;
                            }

                            break;
                        case State.InsideExpression:
                            c = reader.Read();
                            switch (c)
                            {
                                case -1:
                                    throw new FormatException();
                                case '}':

                                    var v = variable.ToString();
                                    if (loop.Add(v) && lookup(v, out string value))
                                    {
                                        value = Eval(value, lookup, loop);
                                        result.Append(value);
                                    }

                                    variable.Length = 0;
                                    state = State.OutsideExpression;
                                    break;
                                default:
                                    variable.Append((char) c);
                                    break;
                            }

                            break;
                        case State.OnCloseBracket:
                            c = reader.Read();
                            switch (c)
                            {
                                case '}':
                                    result.Append('}');
                                    state = State.OutsideExpression;
                                    break;
                                default:
                                    throw new FormatException();
                            }

                            break;
                        default:
                            throw new FormatException("Invalid parse state.");
                    }
                } while (state != State.End);
            }

            return result.ToString();
        }


        private enum State
        {
            OutsideExpression,
            OnOpenBracket,
            InsideExpression,
            OnCloseBracket,
            End
        }
    }
}
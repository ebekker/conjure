// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.Options;

// This code is _*heavily*_ based on EFG:
//    https://github.com/loresoft/EntityFrameworkCore.Generator/

/// <summary>
/// Variable substitution dictionary
/// </summary>
public class VariableDictionary
{
    private readonly Dictionary<string, string> _variables = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);


    /// <summary>
    /// Gets or sets a value indicating whether <see cref="Get"/> should evaluate variable expressions.
    /// </summary>
    /// <value>
    ///   <c>true</c> if <see cref="Get"/> should evaluate; otherwise, <c>false</c>.
    /// </value>
    public bool ShouldEvaluate { get; set; } = true;

    /// <summary>
    /// Gets or sets a variable by name.
    /// </summary>
    /// <param name="name">The name of the variable to set.</param>
    /// <returns>The current (evaluated) value of the variable.</returns>
    public string this[string name]
    {
        get => Get(name);
        set => Set(name, value);
    }


    /// <summary>
    /// Sets a variable value.
    /// </summary>
    /// <param name="name">The name of the variable.</param>
    /// <param name="value">The value of the variable.</param>
    public void Set(string name, string value)
    {
        if (name == null)
            return;

        _variables[name] = value;
    }

    /// <summary>
    /// Sets the specified option variable.
    /// </summary>
    /// <param name="optionVariable">The option variable.</param>
    public void Set(IOptionVariable optionVariable)
    {
        optionVariable.Set(this);
    }

    /// <summary>
    /// Gets the value of a variable, or returns <c>null</c> if the variable is not defined. If the variable contains an expression, it will be evaluated first.
    /// </summary>
    /// <param name="name">The name of the variable.</param>
    /// <returns>
    /// The value of the variable, or <c>null</c> if the variable is not defined.
    /// </returns>
    public string Get(string name)
    {
        if (!_variables.TryGetValue(name, out var variable))
            return null;


        return ShouldEvaluate ? Evaluate(variable) : variable;
    }

    /// <summary>
    /// Removes the variable with specified name.
    /// </summary>
    /// <param name="name">The variable name.</param>
    public void Remove(string name)
    {
        if (name == null)
            return;

        if (_variables.ContainsKey(name))
            _variables.Remove(name);
    }

    /// <summary>
    /// Removes the specified option variable.
    /// </summary>
    /// <param name="optionVariable">The option variable.</param>
    public void Remove(IOptionVariable optionVariable)
    {
        optionVariable.Remove(this);
    }

    /// <summary>
    /// Evaluates the specified variable or text.
    /// </summary>
    /// <param name="variableOrText">The variable or text.</param>
    /// <returns>The result of the variable.</returns>
    /// <exception cref="System.FormatException">Invalid variable format</exception>
    public string Evaluate(string variableOrText)
    {
        if (variableOrText == null)
            return null;

        return Evaluator.Eval(variableOrText, _variables);
    }
}

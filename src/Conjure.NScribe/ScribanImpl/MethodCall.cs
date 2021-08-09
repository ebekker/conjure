using System.Reflection;

namespace Conjure.NScribe.ScribanImpl
{
    public class MethodCall
    {
        public object Target { get; set; }

        public string MethodName { get; set; }

        public MethodInfo Method { get; set; }

        public override string ToString()
        {
            return $"[{Target.ToString()}]#{Method?.Name??MethodName}";
        }
    }
}
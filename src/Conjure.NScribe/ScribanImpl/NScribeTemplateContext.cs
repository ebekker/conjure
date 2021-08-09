using System;
using System.Collections;
using Scriban;
using Scriban.Helpers;
using Scriban.Runtime;
using Scriban.Runtime.Accessors;

namespace Conjure.NScribe.ScribanImpl
{
    public class NScribeTemplateContext : TemplateContext
    {
        protected override IObjectAccessor GetMemberAccessorImpl(object target)
        {
            // Duplicated from Scriban.TemplateContext#GetMemberAccessorImpl
            
            var type = target.GetType();
            IObjectAccessor accessor;
            if (target is IScriptObject)
            {
                accessor = ScriptObjectAccessor.Default;
            }
            else if (target is string)
            {
                accessor = StringAccessor.Default;
            }
            else if (type.IsPrimitiveOrDecimal())
            {
                throw new NotImplementedException("member access of a primitive or decimal");
                //accessor = PrimitiveAccessor.Default;
            }
            else if (DictionaryAccessor.TryGet(target, out accessor))
            {
            }
            else if (type.IsArray)
            {
                accessor = ArrayAccessor.Default;
            }
            else if (target is IList)
            {
                accessor = ListAccessor.Default;
            }
            else
            {
                accessor = new NScribeTypedObjectAccessor(type, MemberFilter, MemberRenamer);
            }

            return accessor;
        }
    }
}
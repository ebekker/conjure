// Conjure application framework.
// Copyright (C) Conjure.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjure.BlazorKit.Util
{
    public interface IConverter<TValue, TTarget>
    {
        TTarget Get(TValue value);

        TValue Set(TTarget target);
    }
}

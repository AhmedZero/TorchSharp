﻿using System;

namespace TorchSharp.JIT
{
    public sealed class DynamicType : Type
    {
        internal DynamicType(IntPtr handle) : base(handle)
        {
            this.handle = new HType(handle, true);
        }
    }
}

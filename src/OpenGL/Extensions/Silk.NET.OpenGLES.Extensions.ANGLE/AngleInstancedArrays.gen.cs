// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [Extension("ANGLE_instanced_arrays")]
    public unsafe partial class AngleInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "ANGLE_instanced_arrays";
        [NativeApi(EntryPoint = "glDrawArraysInstancedANGLE")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] ANGLE mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedANGLE")]
        public partial unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] ANGLE mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ANGLE type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedANGLE")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] ANGLE mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ANGLE type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribDivisorANGLE")]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glDrawArraysInstancedANGLE")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedANGLE")]
        public partial unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedANGLE")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public AngleInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


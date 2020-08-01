// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_ES2_compatibility")]
    public unsafe partial class ArbES2Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES2_compatibility";
        [NativeApi(EntryPoint = "glClearDepthf")]
        public partial void ClearDepth([Flow(FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glDepthRangef")]
        public partial void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        public ArbES2Compatibility(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


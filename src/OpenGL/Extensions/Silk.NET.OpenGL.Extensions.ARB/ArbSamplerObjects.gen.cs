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
    [Extension("ARB_sampler_objects")]
    public unsafe partial class ArbSamplerObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sampler_objects";
        [NativeApi(EntryPoint = "glBindSampler")]
        public partial void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public partial unsafe void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public partial unsafe void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsSampler")]
        public partial bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public ArbSamplerObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


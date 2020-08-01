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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_texture_border_clamp")]
    public unsafe partial class OesTextureBorderClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_border_clamp";
        [NativeApi(EntryPoint = "glGetSamplerParameterIivOES")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivOES")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivOES")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivOES")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivOES")]
        public partial unsafe void GetTexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivOES")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivOES")]
        public partial unsafe void GetTexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivOES")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glSamplerParameterIivOES")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIivOES")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivOES")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivOES")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glTexParameterIivOES")]
        public partial unsafe void TexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivOES")]
        public partial void TexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuivOES")]
        public partial unsafe void TexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivOES")]
        public partial void TexParameterI([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivOES")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivOES")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivOES")]
        public partial unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivOES")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivOES")]
        public partial unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivOES")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivOES")]
        public partial unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivOES")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glSamplerParameterIivOES")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIivOES")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivOES")]
        public partial unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivOES")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glTexParameterIivOES")]
        public partial unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivOES")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuivOES")]
        public partial unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivOES")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        public OesTextureBorderClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


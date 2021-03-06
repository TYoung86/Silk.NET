// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_shader_framebuffer_fetch_non_coherent")]
    public abstract unsafe partial class ExtShaderFramebufferFetchNonCoherent : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_framebuffer_fetch_non_coherent";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glFramebufferFetchBarrierEXT")]
        public abstract void FramebufferFetchBarrier();

        public ExtShaderFramebufferFetchNonCoherent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}


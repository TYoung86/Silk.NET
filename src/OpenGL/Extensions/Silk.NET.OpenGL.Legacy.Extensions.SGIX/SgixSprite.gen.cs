// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_sprite")]
    public unsafe partial class SgixSprite : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_sprite";
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public partial unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public partial unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public partial unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public partial unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public partial void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public SgixSprite(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


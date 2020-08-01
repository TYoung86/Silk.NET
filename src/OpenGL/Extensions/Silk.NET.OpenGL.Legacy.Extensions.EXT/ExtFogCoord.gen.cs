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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_fog_coord")]
    public unsafe partial class ExtFogCoord : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fog_coord";
        [NativeApi(EntryPoint = "glFogCoordfEXT")]
        public partial void FogCoord([Flow(FlowDirection.In)] float coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        public partial unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] float* coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        public partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref float coord);

        [NativeApi(EntryPoint = "glFogCoorddEXT")]
        public partial void FogCoord([Flow(FlowDirection.In)] double coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        public partial unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] double* coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        public partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref double coord);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public partial unsafe void FogCoordPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public partial void FogCoordPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public partial unsafe void FogCoordPointer([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public partial void FogCoordPointer<T0>([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtFogCoord(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


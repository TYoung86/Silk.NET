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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_framebuffer_mixed_samples")]
    public unsafe partial class NVFramebufferMixedSamples : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_mixed_samples";
        [NativeApi(EntryPoint = "glCoverageModulationNV")]
        public partial void CoverageModulation([Flow(FlowDirection.In)] NV components);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        public partial unsafe void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        public partial void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        public partial unsafe void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        public partial void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glRasterSamplesEXT")]
        public partial void RasterSamples([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public unsafe float GetCoverageModulationTable()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetCoverageModulationTable(bufSize, &ret);
            return ret;
        }

        public NVFramebufferMixedSamples(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


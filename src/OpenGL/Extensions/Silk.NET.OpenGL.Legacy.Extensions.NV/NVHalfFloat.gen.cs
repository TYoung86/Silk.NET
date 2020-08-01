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
    [Extension("NV_half_float")]
    public unsafe partial class NVHalfFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_half_float";
        [NativeApi(EntryPoint = "glColor3hNV")]
        public partial void Color3h([Flow(FlowDirection.In)] System.Half red, [Flow(FlowDirection.In)] System.Half green, [Flow(FlowDirection.In)] System.Half blue);

        [NativeApi(EntryPoint = "glColor3hvNV")]
        public partial unsafe void Color3h([Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glColor3hvNV")]
        public partial void Color3h([Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glColor4hNV")]
        public partial void Color4h([Flow(FlowDirection.In)] System.Half red, [Flow(FlowDirection.In)] System.Half green, [Flow(FlowDirection.In)] System.Half blue, [Flow(FlowDirection.In)] System.Half alpha);

        [NativeApi(EntryPoint = "glColor4hvNV")]
        public partial unsafe void Color4h([Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glColor4hvNV")]
        public partial void Color4h([Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glFogCoordhNV")]
        public partial void FogCoordh([Flow(FlowDirection.In)] System.Half fog);

        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        public partial unsafe void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] System.Half* fog);

        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        public partial void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] ref System.Half fog);

        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        public partial void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public partial unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public partial void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] ref System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        public partial void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public partial unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public partial void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        public partial void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public partial unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public partial void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        public partial void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r, [Flow(FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public partial unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public partial void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glNormal3hNV")]
        public partial void Normal3h([Flow(FlowDirection.In)] System.Half nx, [Flow(FlowDirection.In)] System.Half ny, [Flow(FlowDirection.In)] System.Half nz);

        [NativeApi(EntryPoint = "glNormal3hvNV")]
        public partial unsafe void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glNormal3hvNV")]
        public partial void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glSecondaryColor3hNV")]
        public partial void SecondaryColor3h([Flow(FlowDirection.In)] System.Half red, [Flow(FlowDirection.In)] System.Half green, [Flow(FlowDirection.In)] System.Half blue);

        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        public partial unsafe void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        public partial void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glTexCoord1hNV")]
        public partial void TexCoord1h([Flow(FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        public partial unsafe void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        public partial void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] ref System.Half v);

        [NativeApi(EntryPoint = "glTexCoord2hNV")]
        public partial void TexCoord2h([Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        public partial unsafe void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        public partial void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glTexCoord3hNV")]
        public partial void TexCoord3h([Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        public partial unsafe void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        public partial void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glTexCoord4hNV")]
        public partial void TexCoord4h([Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r, [Flow(FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        public partial unsafe void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        public partial void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertex2hNV")]
        public partial void Vertex2h([Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y);

        [NativeApi(EntryPoint = "glVertex2hvNV")]
        public partial unsafe void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex2hvNV")]
        public partial void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertex3hNV")]
        public partial void Vertex3h([Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y, [Flow(FlowDirection.In)] System.Half z);

        [NativeApi(EntryPoint = "glVertex3hvNV")]
        public partial unsafe void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex3hvNV")]
        public partial void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertex4hNV")]
        public partial void Vertex4h([Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y, [Flow(FlowDirection.In)] System.Half z, [Flow(FlowDirection.In)] System.Half w);

        [NativeApi(EntryPoint = "glVertex4hvNV")]
        public partial unsafe void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertex4hvNV")]
        public partial void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttrib1hNV")]
        public partial void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] System.Half x);

        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        public partial unsafe void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        public partial void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref System.Half v);

        [NativeApi(EntryPoint = "glVertexAttrib2hNV")]
        public partial void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y);

        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        public partial unsafe void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        public partial void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttrib3hNV")]
        public partial void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y, [Flow(FlowDirection.In)] System.Half z);

        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        public partial unsafe void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        public partial void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttrib4hNV")]
        public partial void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] System.Half x, [Flow(FlowDirection.In)] System.Half y, [Flow(FlowDirection.In)] System.Half z, [Flow(FlowDirection.In)] System.Half w);

        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        public partial unsafe void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        public partial void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        public partial unsafe void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        public partial void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        public partial unsafe void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        public partial void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        public partial unsafe void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        public partial void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        public partial unsafe void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        public partial void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glVertexWeighthNV")]
        public partial void VertexWeighth([Flow(FlowDirection.In)] System.Half weight);

        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        public partial unsafe void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] System.Half* weight);

        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        public partial void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] ref System.Half weight);

        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        public partial void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] System.Half s);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public partial unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        public partial void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref System.Half v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        public partial void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public partial unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        public partial void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        public partial void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public partial unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        public partial void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<System.Half> v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        public partial void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] System.Half s, [Flow(FlowDirection.In)] System.Half t, [Flow(FlowDirection.In)] System.Half r, [Flow(FlowDirection.In)] System.Half q);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public partial unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] System.Half* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        public partial void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<System.Half> v);

        public NVHalfFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


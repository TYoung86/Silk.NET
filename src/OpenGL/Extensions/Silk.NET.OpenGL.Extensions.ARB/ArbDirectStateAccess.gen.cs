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
    [Extension("ARB_direct_state_access")]
    public unsafe partial class ArbDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_direct_state_access";
        [NativeApi(EntryPoint = "glBindTextureUnit")]
        public partial void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public partial void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public partial ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        public partial void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        public partial void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        public partial void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        public partial void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public partial unsafe void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public partial void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public partial unsafe void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public partial void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public partial unsafe void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public partial void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial unsafe void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public partial unsafe void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public partial void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public partial unsafe void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public partial void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial unsafe void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public partial unsafe void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public partial void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public partial unsafe void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public partial void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        public partial void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        public partial void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        public partial void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        public partial void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public partial unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public partial void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public partial unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public partial unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public partial void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public partial void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial unsafe void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public partial unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        public partial unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public partial unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public partial void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public partial unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public partial void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public partial void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ARB* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ARB> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public partial void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        public partial void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        public partial void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        public partial bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        public partial void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public partial void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public partial void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public partial void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        public partial void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        public partial void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        public partial void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public partial unsafe void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public partial void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public partial void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public partial ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial unsafe void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial unsafe void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public partial unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public partial void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial unsafe void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public partial unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public partial void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public partial void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public partial void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public partial void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public partial void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public ArbDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


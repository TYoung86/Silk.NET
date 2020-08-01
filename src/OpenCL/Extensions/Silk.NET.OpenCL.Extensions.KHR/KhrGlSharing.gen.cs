// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_gl_sharing")]
    public unsafe partial class KhrGlSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_sharing";
        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        public partial unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        public partial IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        public partial unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        public partial IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        public partial unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        public partial IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        public partial unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        public partial IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        public partial unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        public partial IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public partial unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public partial unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public partial unsafe int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public partial int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public partial unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public partial int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] Span<uint> gl_object_type, [Flow(FlowDirection.Out)] Span<uint> gl_object_name);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public partial unsafe int GetGltextureInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public partial int GetGltextureInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        public unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlbuffer(new IntPtr(context), flags, bufobj, errcode_ret);
        }

        public unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlbuffer(new IntPtr(context), flags, bufobj, errcode_ret);
        }

        public unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlrenderbuffer(new IntPtr(context), flags, renderbuffer, errcode_ret);
        }

        public unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlrenderbuffer(new IntPtr(context), flags, renderbuffer, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture2D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture2D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture3D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture3D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        public unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetGlcontextInfo(properties, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetGlcontextInfo(properties, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name)
        {
            // IntPtrOverloader
            return GetGlobjectInfo(new IntPtr(memobj), gl_object_type, gl_object_name);
        }

        public unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] Span<uint> gl_object_type, [Flow(FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // IntPtrOverloader
            return GetGlobjectInfo(new IntPtr(memobj), gl_object_type, gl_object_name);
        }

        public unsafe int GetGltextureInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetGltextureInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetGltextureInfo<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetGltextureInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public KhrGlSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


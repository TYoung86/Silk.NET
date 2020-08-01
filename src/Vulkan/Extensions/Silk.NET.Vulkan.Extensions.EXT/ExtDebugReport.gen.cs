// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_debug_report")]
    public unsafe partial class ExtDebugReport : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_report";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public partial unsafe Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public partial unsafe void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public partial void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Flow(FlowDirection.In)] string pMessage);

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, pLayerPrefix, pMessage);
        }

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, ref pLayerPrefix, ref pMessage);
        }

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Flow(FlowDirection.In)] string pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, pLayerPrefix, pMessage);
        }

        public ExtDebugReport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


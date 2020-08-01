// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_vulkan_enable")]
    public unsafe partial class KhrVulkanEnable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_vulkan_enable";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR")]
        public partial unsafe Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR")]
        public partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, Span<byte> buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDeviceKHR")]
        public partial unsafe Result GetVulkanGraphicsDevice([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vkPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDeviceKHR")]
        public partial Result GetVulkanGraphicsDevice([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vkPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirementsKHR")]
        public partial unsafe Result GetVulkanGraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsVulkanKHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirementsKHR")]
        public partial Result GetVulkanGraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsVulkanKHR graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR")]
        public partial unsafe Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR")]
        public partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, Span<byte> buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR")]
        public partial unsafe Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR")]
        public partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR")]
        public partial unsafe Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR")]
        public partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        public KhrVulkanEnable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


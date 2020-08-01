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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_swapchain")]
    public unsafe partial class KhrSwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_swapchain";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR")]
        public partial unsafe Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR")]
        public partial Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public partial unsafe Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR")]
        public partial unsafe Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR")]
        public partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR")]
        public partial unsafe void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR")]
        public partial void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        public partial unsafe Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        public partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        public partial unsafe Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        public partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public partial unsafe Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR")]
        public partial unsafe Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pSwapchainImageCount, [Count(Computed = "pSwapchainImageCount"), Flow(FlowDirection.Out)] Image* pSwapchainImages);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR")]
        public partial Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pSwapchainImageCount, [Count(Computed = "pSwapchainImageCount"), Flow(FlowDirection.Out)] out Image pSwapchainImages);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR")]
        public partial unsafe Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] PresentInfoKHR* pPresentInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR")]
        public partial Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref PresentInfoKHR pPresentInfo);

        public KhrSwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


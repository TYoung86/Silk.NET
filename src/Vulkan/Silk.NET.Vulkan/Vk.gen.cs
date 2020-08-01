// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe partial class Vk : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "VK_ATTACHMENT_UNUSED")]
        public const uint AttachmentUnused = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_FALSE")]
        public const uint False = 0;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LOD_CLAMP_NONE")]
        public const float LodClampNone = 1000.0f;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE")]
        public const uint LuidSize = 8;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE_KHR")]
        public const uint LuidSizeKhr = 8;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DESCRIPTION_SIZE")]
        public const uint MaxDescriptionSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE")]
        public const uint MaxDeviceGroupSize = 32;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE_KHR")]
        public const uint MaxDeviceGroupSizeKhr = 32;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE")]
        public const uint MaxDriverInfoSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE_KHR")]
        public const uint MaxDriverInfoSizeKhr = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE")]
        public const uint MaxDriverNameSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE_KHR")]
        public const uint MaxDriverNameSizeKhr = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_EXTENSION_NAME_SIZE")]
        public const uint MaxExtensionNameSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_HEAPS")]
        public const uint MaxMemoryHeaps = 16;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_TYPES")]
        public const uint MaxMemoryTypes = 32;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_PHYSICAL_DEVICE_NAME_SIZE")]
        public const uint MaxPhysicalDeviceNameSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint QueueFamilyExternal = (~0U-1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL_KHR")]
        public const uint QueueFamilyExternalKhr = (~0U-1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_FOREIGN_EXT")]
        public const uint QueueFamilyForeignExt = (~0U-2);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_IGNORED")]
        public const uint QueueFamilyIgnored = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_ARRAY_LAYERS")]
        public const uint RemainingArrayLayers = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_MIP_LEVELS")]
        public const uint RemainingMipLevels = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_KHR")]
        public const uint ShaderUnusedKhr = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_NV")]
        public const uint ShaderUnusedNV = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SUBPASS_EXTERNAL")]
        public const uint SubpassExternal = (~0U);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_TRUE")]
        public const uint True = 1;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_UUID_SIZE")]
        public const uint UuidSize = 16;
        [NativeName("Type", "")]
        [NativeName("Name", "VK_WHOLE_SIZE")]
        public const ulong WholeSize = (~0ul);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public partial unsafe void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        public partial void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCount")]
        public partial void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public partial unsafe void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public partial unsafe void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public partial unsafe Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public partial unsafe ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public partial unsafe ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public partial unsafe ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceMemoryOpaqueCaptureAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public partial unsafe Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPool")]
        public partial void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public partial unsafe Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreSignalInfo pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public partial unsafe Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public partial unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindBufferMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public partial unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindImageMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBase")]
        public partial void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMask")]
        public partial void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public partial unsafe Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public partial unsafe Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public partial unsafe void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public partial void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public partial unsafe void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public partial unsafe Result EnumerateInstanceVersion([Count(Count = 0)] uint* pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public partial Result EnumerateInstanceVersion([Count(Count = 0)] ref uint pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public partial unsafe Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public partial unsafe void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public partial unsafe void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public partial unsafe void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public partial unsafe void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceQueueInfo2 pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public partial unsafe void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public partial unsafe void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public partial unsafe void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public partial unsafe void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public partial unsafe void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public partial unsafe void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public partial unsafe void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public partial unsafe Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public partial unsafe void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public partial unsafe void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public partial unsafe void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public partial unsafe void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPool")]
        public partial void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public partial unsafe void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public partial void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public partial unsafe Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] out CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public partial unsafe Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] DescriptorSet* pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] out DescriptorSet pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public partial unsafe Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public partial unsafe Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferBeginInfo* pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public partial Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferBeginInfo pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory")]
        public partial Result BindBufferMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory")]
        public partial Result BindImageMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQuery")]
        public partial void CmdBeginQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public partial unsafe void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public partial void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public partial unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] ref uint pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer")]
        public partial void CmdBindIndexBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] IndexType indexType);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipeline")]
        public partial void CmdBindPipeline([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public partial unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public partial unsafe void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageBlit* pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public partial void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageBlit pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public partial unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ref ClearAttachment pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ref ClearRect pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public partial unsafe void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearColorValue pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public partial unsafe void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearDepthStencilValue pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public partial unsafe void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public partial void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public partial unsafe void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public partial void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public partial unsafe void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public partial void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public partial unsafe void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public partial void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyQueryPoolResults")]
        public partial void CmdCopyQueryPoolResults([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatch")]
        public partial void CmdDispatch([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchIndirect")]
        public partial void CmdDispatchIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDraw")]
        public partial void CmdDraw([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstVertex, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexed")]
        public partial void CmdDrawIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint indexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstIndex, [Count(Count = 0)] int vertexOffset, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirect")]
        public partial void CmdDrawIndexedIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirect")]
        public partial void CmdDrawIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQuery")]
        public partial void CmdEndQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass")]
        public partial void CmdEndRenderPass([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public partial unsafe void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public partial void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdFillBuffer")]
        public partial void CmdFillBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint data);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass")]
        public partial void CmdNextSubpass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public partial unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public partial unsafe void CmdPushConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] void* pValues);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public partial void CmdPushConstants<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] ref T0 pValues) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent")]
        public partial void CmdResetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetQueryPool")]
        public partial void CmdResetQueryPool([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public partial unsafe void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageResolve* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public partial void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageResolve pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants")]
        public partial void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float blendConstants);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBias")]
        public partial void CmdSetDepthBias([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float depthBiasConstantFactor, [Count(Count = 0)] float depthBiasClamp, [Count(Count = 0)] float depthBiasSlopeFactor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBounds")]
        public partial void CmdSetDepthBounds([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float minDepthBounds, [Count(Count = 0)] float maxDepthBounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent")]
        public partial void CmdSetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineWidth")]
        public partial void CmdSetLineWidth([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float lineWidth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public partial unsafe void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public partial void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] ref Rect2D pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilCompareMask")]
        public partial void CmdSetStencilCompareMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint compareMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilReference")]
        public partial void CmdSetStencilReference([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint reference);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilWriteMask")]
        public partial void CmdSetStencilWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint writeMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public partial unsafe void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public partial void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref Viewport pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public partial unsafe void CmdUpdateBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public partial void CmdUpdateBuffer<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public partial unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] ref Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp")]
        public partial void CmdWriteTimestamp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public partial unsafe Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public partial unsafe Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public partial unsafe Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public partial unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public partial unsafe Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public partial unsafe Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public partial unsafe Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public partial unsafe Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public partial unsafe Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public partial unsafe Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public partial unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public partial unsafe Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public partial unsafe Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public partial unsafe Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] ref InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public partial unsafe Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public partial unsafe Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public partial unsafe Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public partial unsafe Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public partial unsafe Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public partial unsafe Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public partial unsafe Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public partial unsafe void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public partial void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public partial unsafe void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public partial void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public partial unsafe void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public partial void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public partial unsafe void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public partial void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public partial unsafe void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public partial void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public partial unsafe void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public partial void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public partial unsafe void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public partial void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public partial unsafe void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public partial void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public partial unsafe void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public partial void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public partial unsafe void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public partial void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public partial unsafe void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public partial void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public partial unsafe void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public partial void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public partial unsafe void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public partial void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public partial unsafe void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public partial void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public partial unsafe void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public partial void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public partial unsafe void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public partial void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public partial unsafe void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public partial void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public partial unsafe void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public partial void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public partial unsafe void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public partial void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public partial unsafe void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public partial void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDeviceWaitIdle")]
        public partial Result DeviceWaitIdle([Count(Count = 0)] Device device);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEndCommandBuffer")]
        public partial Result EndCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public partial unsafe Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public partial unsafe Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public partial unsafe Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] ref PhysicalDevice pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public partial unsafe Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public partial Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public partial unsafe void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public partial void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public partial unsafe Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public partial Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public partial unsafe void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public partial void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public partial unsafe void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public partial void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public partial unsafe void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public partial void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public partial unsafe FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public partial FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public partial unsafe void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public partial void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetEventStatus")]
        public partial Result GetEventStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceStatus")]
        public partial Result GetFenceStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public partial unsafe void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public partial void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public partial unsafe void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public partial unsafe void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout* pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSubresource pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public partial unsafe FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public partial FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public partial unsafe void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures* pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public partial void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public partial unsafe void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties* pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public partial void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public partial unsafe Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties* pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public partial Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public partial unsafe void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties* pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public partial void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public partial unsafe void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public partial void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public partial unsafe void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public partial unsafe void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public partial unsafe Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public partial Result GetPipelineCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public partial unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public partial Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public partial unsafe void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public partial void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public partial unsafe Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public partial Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public partial unsafe Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] void** ppData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public partial unsafe Result MapMemory<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] ref T0* ppData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public partial unsafe Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] PipelineCache* pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public partial Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ref PipelineCache pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public partial unsafe Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindSparseInfo* pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public partial Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindSparseInfo pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public partial unsafe Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] SubmitInfo* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public partial Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] ref SubmitInfo pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueWaitIdle")]
        public partial Result QueueWaitIdle([Count(Count = 0)] Queue queue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandBuffer")]
        public partial Result ResetCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CommandBufferResetFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandPool")]
        public partial Result ResetCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] CommandPoolResetFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetDescriptorPool")]
        public partial Result ResetDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetEvent")]
        public partial Result ResetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public partial unsafe Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public partial Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetEvent")]
        public partial Result SetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory")]
        public partial void UnmapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public partial unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] ref WriteDescriptorSet pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] ref CopyDescriptorSet pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public partial unsafe Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public partial Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial unsafe Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public partial FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public partial FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceFeatures GetPhysicalDeviceFeature([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures ret = default;
            GetPhysicalDeviceFeatures(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties ret = default;
            GetPhysicalDeviceMemoryProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceProperties GetPhysicalDeviceProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties ret = default;
            GetPhysicalDeviceProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags)
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), pData, stride, flags);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), ref pData, stride, flags);
        }


        public Vk(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


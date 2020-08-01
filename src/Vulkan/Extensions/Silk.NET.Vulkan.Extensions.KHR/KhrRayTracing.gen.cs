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
    [Extension("VK_KHR_ray_tracing")]
    public unsafe partial class KhrRayTracing : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_ray_tracing";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        public partial unsafe Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindAccelerationStructureMemoryInfoKHR* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryKHR")]
        public partial Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindAccelerationStructureMemoryInfoKHR pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        public partial unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBuildAccelerationStructureKHR")]
        public partial unsafe Result BuildAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        public partial unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] AccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureKHR")]
        public partial unsafe void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfos, [Count(Computed = "infoCount"), Flow(FlowDirection.In)] ref AccelerationStructureBuildOffsetInfoKHR* ppOffsetInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        public partial unsafe void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureBuildGeometryInfoKHR* pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureIndirectKHR")]
        public partial void CmdBuildAccelerationStructureIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureBuildGeometryInfoKHR pInfo, [Count(Count = 0)] Buffer indirectBuffer, [Count(Count = 0)] ulong indirectOffset, [Count(Count = 0)] uint indirectStride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public partial unsafe void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public partial unsafe void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public partial void CmdCopyAccelerationStructureToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public partial unsafe void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public partial void CmdCopyMemoryToAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public partial unsafe void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysKHR")]
        public partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public partial unsafe void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] StridedBufferRegionKHR* pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public partial void CmdTraceRaysIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pRaygenShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pMissShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pHitShaderBindingTable, [Count(Count = 0), Flow(FlowDirection.In)] ref StridedBufferRegionKHR pCallableShaderBindingTable, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public partial unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public partial unsafe Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureKHR")]
        public partial Result CopyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public partial unsafe Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyAccelerationStructureToMemoryInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public partial Result CopyAccelerationStructureToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyAccelerationStructureToMemoryInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public partial unsafe Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CopyMemoryToAccelerationStructureInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public partial Result CopyMemoryToAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CopyMemoryToAccelerationStructureInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public partial unsafe Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureKHR* pAccelerationStructure);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureKHR")]
        public partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureKHR pAccelerationStructure);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public partial unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref RayTracingPipelineCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public partial unsafe void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureKHR accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public partial unsafe ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureDeviceAddressInfoKHR* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public partial ulong GetAccelerationStructureDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureDeviceAddressInfoKHR pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        public partial unsafe void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoKHR* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsKHR")]
        public partial void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureMemoryRequirementsInfoKHR pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public partial unsafe Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureVersionKHR* version);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public partial Result GetDeviceAccelerationStructureCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AccelerationStructureVersionKHR version);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public partial unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public partial Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public partial unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public partial Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public partial unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] UIntPtr stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public partial Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] UIntPtr stride) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingCaptureReplayShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingCaptureReplayShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData)
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, new UIntPtr(dataSize), ref pData);
        }

        /// <summary>To be added.</summary>
        public unsafe Result WriteAccelerationStructuresProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureKHR* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] uint stride)
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, pAccelerationStructures, queryType, new UIntPtr(dataSize), pData, new UIntPtr(stride));
        }

        /// <summary>To be added.</summary>
        public unsafe Result WriteAccelerationStructuresProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint accelerationStructureCount, [Count(Computed = "accelerationStructureCount"), Flow(FlowDirection.In)] ref AccelerationStructureKHR pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            return WriteAccelerationStructuresProperties(device, accelerationStructureCount, ref pAccelerationStructures, queryType, new UIntPtr(dataSize), ref pData, new UIntPtr(stride));
        }

        public KhrRayTracing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


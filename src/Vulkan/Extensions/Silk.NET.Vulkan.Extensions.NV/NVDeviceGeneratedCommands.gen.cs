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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_device_generated_commands")]
    public unsafe partial class NVDeviceGeneratedCommands : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_generated_commands";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
        public partial void CmdBindPipelineShaderGroup([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint groupIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        public unsafe partial void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        public partial void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        public unsafe partial void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        public partial void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        public partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref IndirectCommandsLayoutCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out IndirectCommandsLayoutNV pIndirectCommandsLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        public unsafe partial void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        public partial void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        public unsafe partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        public partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        public NVDeviceGeneratedCommands(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


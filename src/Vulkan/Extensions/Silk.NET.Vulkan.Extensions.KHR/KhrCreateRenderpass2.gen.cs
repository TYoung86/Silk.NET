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
    [Extension("VK_KHR_create_renderpass2")]
    public unsafe partial class KhrCreateRenderpass2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_create_renderpass2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR")]
        public partial unsafe void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2KHR")]
        public partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2KHR")]
        public partial unsafe void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2KHR")]
        public partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR")]
        public partial unsafe void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2KHR")]
        public partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR")]
        public partial unsafe Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2KHR")]
        public partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        public KhrCreateRenderpass2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


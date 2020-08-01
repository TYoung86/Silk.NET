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
    [Extension("VK_KHR_external_semaphore_fd")]
    public unsafe partial class KhrExternalSemaphoreFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_fd";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR")]
        public partial unsafe Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR")]
        public partial Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR")]
        public partial unsafe Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR")]
        public partial Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo);

        public KhrExternalSemaphoreFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


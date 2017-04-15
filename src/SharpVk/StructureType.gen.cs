// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum StructureType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationInfo = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InstanceCreateInfo = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceQueueCreateInfo = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceCreateInfo = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        SubmitInfo = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryAllocateInfo = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        MappedMemoryRange = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        BindSparseInfo = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceCreateInfo = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreCreateInfo = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        EventCreateInfo = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        QueryPoolCreateInfo = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferCreateInfo = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferViewCreateInfo = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageCreateInfo = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageViewCreateInfo = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderModuleCreateInfo = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCacheCreateInfo = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineShaderStageCreateInfo = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineTessellationStateCreateInfo = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportStateCreateInfo = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDynamicStateCreateInfo = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        GraphicsPipelineCreateInfo = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputePipelineCreateInfo = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineLayoutCreateInfo = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerCreateInfo = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorPoolCreateInfo = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetAllocateInfo = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteDescriptorSet = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyDescriptorSet = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        FramebufferCreateInfo = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassCreateInfo = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPoolCreateInfo = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferAllocateInfo = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferInheritanceInfo = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferBeginInfo = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassBeginInfo = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferMemoryBarrier = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMemoryBarrier = 45, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryBarrier = 46, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderInstanceCreateInfo = 47, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderDeviceCreateInfo = 48, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCreateInfoKhr = 1000001000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentInfoKhr = 1000001001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayModeCreateInfoKhr = 1000002000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplaySurfaceCreateInfoKhr = 1000002001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPresentInfoKhr = 1000003000, 
        
        /// <summary>
        /// 
        /// </summary>
        XlibSurfaceCreateInfoKhr = 1000004000, 
        
        /// <summary>
        /// 
        /// </summary>
        XcbSurfaceCreateInfoKhr = 1000005000, 
        
        /// <summary>
        /// 
        /// </summary>
        WaylandSurfaceCreateInfoKhr = 1000006000, 
        
        /// <summary>
        /// 
        /// </summary>
        MirSurfaceCreateInfoKhr = 1000007000, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidSurfaceCreateInfoKhr = 1000008000, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32SurfaceCreateInfoKhr = 1000009000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugReportCallbackCreateInfoExt = 1000011000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectNameInfoExt = 1000022000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectTagInfoExt = 1000022001, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerMarkerInfoExt = 1000022002, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationImageCreateInfoNv = 1000026000, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationBufferCreateInfoNv = 1000026001, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationMemoryAllocateInfoNv = 1000026002, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassMultiviewCreateInfoKhx = 1000053000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewFeaturesKhx = 1000053001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewPropertiesKhx = 1000053002, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryImageCreateInfoNv = 1000056000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryAllocateInfoNv = 1000056001, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoNv = 1000057000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoNv = 1000057001, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoNv = 1000058000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFeatures2Khr = 1000059000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceProperties2Khr = 1000059001, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatProperties2Khr = 1000059002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageFormatProperties2Khr = 1000059003, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceImageFormatInfo2Khr = 1000059004, 
        
        /// <summary>
        /// 
        /// </summary>
        QueueFamilyProperties2Khr = 1000059005, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMemoryProperties2Khr = 1000059006, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseImageFormatProperties2Khr = 1000059007, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSparseImageFormatInfo2Khr = 1000059008, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryAllocateFlagsInfoKhx = 1000060000, 
        
        /// <summary>
        /// 
        /// </summary>
        BindBufferMemoryInfoKhx = 1000060001, 
        
        /// <summary>
        /// 
        /// </summary>
        BindImageMemoryInfoKhx = 1000060002, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupRenderPassBeginInfoKhx = 1000060003, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupCommandBufferBeginInfoKhx = 1000060004, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupSubmitInfoKhx = 1000060005, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupBindSparseInfoKhx = 1000060006, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentCapabilitiesKhx = 1000060007, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageSwapchainCreateInfoKhx = 1000060008, 
        
        /// <summary>
        /// 
        /// </summary>
        BindImageMemorySwapchainInfoKhx = 1000060009, 
        
        /// <summary>
        /// 
        /// </summary>
        AcquireNextImageInfoKhx = 1000060010, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentInfoKhx = 1000060011, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupSwapchainCreateInfoKhx = 1000060012, 
        
        /// <summary>
        /// 
        /// </summary>
        ValidationFlagsExt = 1000061000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViSurfaceCreateInfoNn = 1000062000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceGroupPropertiesKhx = 1000070000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupDeviceCreateInfoKhx = 1000070001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalImageFormatInfoKhx = 1000071000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalImageFormatPropertiesKhx = 1000071001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalBufferInfoKhx = 1000071002, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalBufferPropertiesKhx = 1000071003, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceIdPropertiesKhx = 1000071004, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryBufferCreateInfoKhx = 1000072000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryImageCreateInfoKhx = 1000072001, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryAllocateInfoKhx = 1000072002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoKhx = 1000073000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoKhx = 1000073001, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWin32HandlePropertiesKhx = 1000073002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryFileDescriptorInfoKhx = 1000074000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryFileDescriptorPropertiesKhx = 1000074001, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoKhx = 1000075000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalSemaphoreInfoKhx = 1000076000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalSemaphorePropertiesKhx = 1000076001, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportSemaphoreCreateInfoKhx = 1000077000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreWin32HandleInfoKhx = 1000078000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportSemaphoreWin32HandleInfoKhx = 1000078001, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d12FenceSubmitInfoKhx = 1000078002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreFileDescriptorInfoKhx = 1000079000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevicePushDescriptorPropertiesKhr = 1000080000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentRegionsKhr = 1000084000, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorUpdateTemplateCreateInfoKhr = 1000085000, 
        
        /// <summary>
        /// 
        /// </summary>
        ObjectTableCreateInfoNvx = 1000086000, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandsLayoutCreateInfoNvx = 1000086001, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandProcessCommandsInfoNvx = 1000086002, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandReserveSpaceForCommandsInfoNvx = 1000086003, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsLimitsNvx = 1000086004, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsFeaturesNvx = 1000086005, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportWScalingStateCreateInfoNv = 1000087000, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceCapabilities2Ext = 1000090000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPowerInfoExt = 1000091000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceEventInfoExt = 1000091001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayEventInfoExt = 1000091002, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCounterCreateInfoExt = 1000091003, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentTimesInfoGoogle = 1000092000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportSwizzleStateCreateInfoNv = 1000098000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDiscardRectangleStateCreateInfoExt = 1000099001, 
        
        /// <summary>
        /// 
        /// </summary>
        HdrMetadataExt = 1000105000, 
        
        /// <summary>
        /// 
        /// </summary>
        IosSurfaceCreateInfoMvk = 1000122000, 
        
        /// <summary>
        /// 
        /// </summary>
        MacosSurfaceCreateInfoMvk = 1000123000, 
    }
}

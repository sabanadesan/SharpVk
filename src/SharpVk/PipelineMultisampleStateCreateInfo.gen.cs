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

using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created pipeline multisample
    /// state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineMultisampleStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.PipelineMultisampleStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:rasterizationSamples is a elink:VkSampleCountFlagBits
        /// specifying the number of samples per pixel used in rasterization.
        /// </summary>
        public SharpVk.SampleCountFlags RasterizationSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampleShadingEnable specifies that fragment shading executes
        /// per-sample if ename:VK_TRUE, or per-fragment if ename:VK_FALSE, as
        /// described in &lt;&lt;primsrast-sampleshading,Sample
        /// Shading&gt;&gt;.
        /// </summary>
        public bool SampleShadingEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minSampleShading is the minimum fraction of sample shading,
        /// as described in &lt;&lt;primsrast-sampleshading,Sample
        /// Shading&gt;&gt;.
        /// </summary>
        public float MinSampleShading
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSampleMask is a bitmask of static coverage information that
        /// is ANDed with the coverage information generated during
        /// rasterization, as described in &lt;&lt;fragops-samplemask,Sample
        /// Mask&gt;&gt;.
        /// </summary>
        public SampleMask[] SampleMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaToCoverageEnable controls whether a temporary coverage
        /// value is generated based on the alpha component of the fragment's
        /// first color output as specified in the
        /// &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt; section.
        /// </summary>
        public bool AlphaToCoverageEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaToOneEnable controls whether the alpha component of the
        /// fragment's first color output is replaced with one as described in
        /// &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt;.
        /// </summary>
        public bool AlphaToOneEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineMultisampleStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineMultisampleStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineMultisampleStateCreateFlags);
            }
            pointer->RasterizationSamples = this.RasterizationSamples;
            pointer->SampleShadingEnable = this.SampleShadingEnable;
            pointer->MinSampleShading = this.MinSampleShading;
            if (this.SampleMask != null)
            {
                var fieldPointer = (SampleMask*)(Interop.HeapUtil.AllocateAndClear<SampleMask>(this.SampleMask.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SampleMask.Length); index++)
                {
                    fieldPointer[index] = this.SampleMask[index];
                }
                pointer->SampleMask = fieldPointer;
            }
            else
            {
                pointer->SampleMask = null;
            }
            pointer->AlphaToCoverageEnable = this.AlphaToCoverageEnable;
            pointer->AlphaToOneEnable = this.AlphaToOneEnable;
        }
    }
}

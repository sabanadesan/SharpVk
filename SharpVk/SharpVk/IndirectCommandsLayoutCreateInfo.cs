// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk
{
    /// <summary>
    /// -
    /// </summary>
    public struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// -
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IndirectCommandsLayoutUsageFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IndirectCommandsLayoutToken[] Tokens
        {
            get;
            set;
        }
        
        internal unsafe Interop.IndirectCommandsLayoutCreateInfo Pack()
        {
            Interop.IndirectCommandsLayoutCreateInfo result = default(Interop.IndirectCommandsLayoutCreateInfo);
            result.SType = StructureType.IndirectCommandsLayoutCreateInfoNvx;
            
            //Tokens
            if (this.Tokens != null)
            {
                result.Tokens = (IndirectCommandsLayoutToken*)Interop.HeapUtil.Allocate<IndirectCommandsLayoutToken>(this.Tokens.Length).ToPointer();
                for (int index = 0; index < this.Tokens.Length; index++)
                {
                    result.Tokens[index] = this.Tokens[index];
                }
            }
            else
            {
                result.Tokens = null;
            }
            result.TokenCount = (uint)(this.Tokens?.Length ?? 0);
            result.PipelineBindPoint = this.PipelineBindPoint;
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.IndirectCommandsLayoutCreateInfo* MarshalTo()
        {
            return (Interop.IndirectCommandsLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}

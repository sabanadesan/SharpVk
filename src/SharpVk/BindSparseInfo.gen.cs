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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct BindSparseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint WaitSemaphoreCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferBindCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageOpaqueBindCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageBindCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SignalSemaphoreCount
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.BindSparseInfo* pointer)
        {
            pointer->SType = StructureType.BindSparseInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = this.WaitSemaphoreCount;
            pointer->BufferBindCount = this.BufferBindCount;
            pointer->ImageOpaqueBindCount = this.ImageOpaqueBindCount;
            pointer->ImageBindCount = this.ImageBindCount;
            pointer->SignalSemaphoreCount = this.SignalSemaphoreCount;
        }
    }
}

// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Specify security attributes and access rights for Win32 memory handles.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExportMemoryWin32HandleInfo
    {
        /// <summary>
        /// A Windows SECURITY_ATTRIBUTES structure specifying security
        /// attributes of the handle.
        /// </summary>
        public SecurityAttributes? Attributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// A DWORD specifying access rights of the handle.
        /// </summary>
        public uint? DwAccess
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo* pointer)
        {
            pointer->SType = StructureType.ExportMemoryWin32HandleInfoNv;
            pointer->Next = null;
            if (this.Attributes != null)
            {
                pointer->Attributes = (SecurityAttributes*)(Interop.HeapUtil.Allocate<SecurityAttributes>());
                *pointer->Attributes = this.Attributes.Value;
            }
            else
            {
                pointer->Attributes = default(SecurityAttributes*);
            }
            if (this.DwAccess != null)
            {
                pointer->DwAccess = this.DwAccess.Value;
            }
            else
            {
                pointer->DwAccess = default(uint);
            }
        }
    }
}

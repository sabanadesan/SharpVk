namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWrite = 1 << 16, 
    }
}

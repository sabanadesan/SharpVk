﻿using System.Collections.Generic;

namespace SharpVk.Generator.Collation
{
    public class EnumDeclaration
    {
        public string Name;
        public bool IsFlags;
        public List<FieldDeclaration> Fields;
    }
}

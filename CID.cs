﻿
namespace EHR.CoreShared
{
    public class CID : ValueObject
    {
        public virtual string Code { get; set; }
        public virtual string AbbreviatedDescription { get; set; }
    }
}

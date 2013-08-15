using System;

namespace EHR.CoreShared
{
    [Serializable]
    public class TUS : ValueObject
    {
        public virtual string Code { get; set; }
    }
}
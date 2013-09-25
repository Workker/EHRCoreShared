using System;

namespace EHR.CoreShared
{
    [Serializable]
    public class TUSS : ValueObject
    {
        public virtual string Code { get; set; }
    }
}
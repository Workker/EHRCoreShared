using System;

namespace EHR.CoreShared.Entities
{
    [Serializable]
    public class TUSS : ValueObject
    {
        public virtual string Code { get; set; }
    }
}
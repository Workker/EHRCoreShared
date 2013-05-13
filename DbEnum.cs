using System.ComponentModel;
using ProtoBuf;
using System;

namespace EHR.CoreShared
{
    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public enum DbEnum : short
    {
        [ProtoEnum(Name = "BarraDor", Value = 1)]
        [Description("Barra'Dor")]
        BarraDor = 1,
        [ProtoEnum(Name = "Sumario", Value = 2)]
        sumario,
        [ProtoEnum(Name = "QuintaDor", Value = 4)]
        QuintaDor

    }
}

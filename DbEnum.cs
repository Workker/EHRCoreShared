using ProtoBuf;
using System;

namespace EHR.CoreShared
{
    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public enum DbEnum : short
    {
        [ProtoEnum(Name = "BarraDor", Value = 1)]
        BarraDor = 1,
        [ProtoEnum(Name = "Sumario", Value = 2)]
        sumario,
        [ProtoEnum(Name = "QuintaDor", Value = 3)]
        QuintaDor,
        [ProtoEnum(Name = "QuintaDor", Value = 4)]
        QuintaDorProd

    }
}

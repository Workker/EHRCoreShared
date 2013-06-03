using System.ComponentModel;
using ProtoBuf;
using System;

namespace EHR.CoreShared
{
    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public enum DbEnum : short
    {
        //View de atendimento não existe no servidor
        //[ProtoEnum(Name = "BarraDor", Value = 1)]
        //[Description("Barra'Dor")]
        //BarraDor = 1,
        [ProtoEnum(Name = "Sumario", Value = 2)]
        sumario = 2,
        [ProtoEnum(Name = "QuintaDor", Value = 4)]
        QuintaDor,
        [ProtoEnum(Name = "Pronto", Value = 5)]
        Pronto,
        [ProtoEnum(Name = "Rios", Value = 6)]
        Rios,
        [ProtoEnum(Name = "Norte", Value = 7)]
        Norte,
        [ProtoEnum(Name = "Esperança", Value = 8)]
        Esperanca,
        [ProtoEnum(Name = "Bangu", Value = 9)]
        Bangu,
        [ProtoEnum(Name = "Copa", Value = 10)]
        Copa,
        [ProtoEnum(Name = "SM", Value = 11)]
        SM
    }
}


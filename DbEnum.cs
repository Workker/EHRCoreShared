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
        sumario,
        [ProtoEnum(Name = "QuintaDor", Value = 4)]
        [Description("Quinta D'Or")]
        QuintaDor,
        [ProtoEnum(Name = "Pronto", Value = 5)]
        [Description("Prontolinda")]
        Pronto,
        [ProtoEnum(Name = "Rios", Value = 6)]
        [Description("Rios D'Or")]
        Rios,
        [ProtoEnum(Name = "Norte", Value = 7)]
        [Description("Norte D'Or")]
        Norte,
        [ProtoEnum(Name = "Esperança", Value = 8)]
        [Description("Esperança")]
        Esperanca,
        [ProtoEnum(Name = "Bangu", Value = 9)]
        [Description("Bangu")]
        Bangu,
        [ProtoEnum(Name = "Copa", Value = 10)]
        [Description("Copa D'Or")]
        Copa,
        [ProtoEnum(Name = "SM", Value = 11)]
        [Description("São Marcos")]
        SM
    }
}


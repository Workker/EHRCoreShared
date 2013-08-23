using System.ComponentModel;
using ProtoBuf;
using System;

namespace EHR.CoreShared
{
    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public enum DbEnum : short
    {

        [ProtoEnum(Name = "Assunção", Value = 1)]
        [Description("Assunção")]
        Assuncao = 1,
        [ProtoEnum(Name = "Badim", Value = 2)]
        [Description("Badim")]
        Badim = 2,
        [ProtoEnum(Name = "Bangu", Value = 3)]
        [Description("Bangu")]
        Bangu = 3,
        //View de atendimento não existe no servidor
        [ProtoEnum(Name = "BarraDor", Value = 4)]
        [Description("Barra'Dor")]
        BarraDor = 4,
        [ProtoEnum(Name = "Brasil", Value = 5)]
        [Description("Brasil")]
        Brasil = 5,
        [ProtoEnum(Name = "Copa D'Or", Value = 6)]
        [Description("Copa D'Or")]
        CopaDor = 6,
        [ProtoEnum(Name = "Esperança", Value = 7)]
        [Description("Esperança")]
        Esperanca = 7,
        [ProtoEnum(Name = "Israelita Albert Sabim", Value = 8)]
        [Description("Israelita Albert Sabim")]
        IsraelitaAlbertSabim = 8,
        [ProtoEnum(Name = "Joari", Value = 9)]
        [Description("Joari")]
        Joari = 9,
        [ProtoEnum(Name = "Niterói D'Or", Value = 10)]
        [Description("Niterói D'Or")]
        NiteroiDOr = 10,
        [ProtoEnum(Name = "Norte D'Or", Value = 11)]
        [Description("Norte D'Or")]
        Norte = 11,
        [ProtoEnum(Name = "Prontolinda", Value = 12)]
        [Description("Prontolinda")]
        Pronto = 12,
        [ProtoEnum(Name = "Quinta D'Or", Value = 13)]
        [Description("Quinta D'Or")]
        QuintaDor = 13,
        [ProtoEnum(Name = "Rede D'Or São Luiz", Value = 14)]
        [Description("Rede D'Or São Luiz")]
        RedeDOrSaoLuiz = 14,
        [ProtoEnum(Name = "Rio de Janeiro", Value = 15)]
        [Description("Rio de Janeiro")]
        RioDeJaneiro = 15,
        [ProtoEnum(Name = "Rios D'Or", Value = 6)]
        [Description("Rios D'Or")]
        RiosDor = 16,
        [ProtoEnum(Name = "São Marcos", Value = 11)]
        [Description("São Marcos")]
        SaoMarcos = 17,
        [ProtoEnum(Name = "Sumario", Value = 99)]
        sumario = 99
    }
}


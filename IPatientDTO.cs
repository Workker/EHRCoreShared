﻿using ProtoBuf;
using System;
using System.Collections.Generic;

namespace EHR.CoreShared
{
    [ProtoContract(SkipConstructor = true)]
    //[ProtoInclude(7, typeof(PatientDTO))]
    public interface IPatientDTO
    {
        [ProtoMember(1)]
        string Id { get; set; }
        [ProtoMember(2)]
        string Name { get; set; }
        [ProtoMember(3)]
        DateTime? DateBirthday { get; set; }
        [ProtoMember(4)]
        string CPF { get; set; }
        [ProtoMember(5)]
        string Identity { get; set; }
        [ProtoMember(6)]
        DbEnum Hospital { get; set; }
        [ProtoMember(7)]
        List<string> Records { get; set; }

        string GetCPF();
        void AddRecord(string record);


        void AddTreatments(IList<ITreatmentDTO> treatments);
    }
}

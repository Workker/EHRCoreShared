using EHR.CoreShared.Entities;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace EHR.CoreShared.Interfaces
{
    [ProtoContract(SkipConstructor = true)]
    //[ProtoInclude(7, typeof(PatientDTO))]
    public interface IPatient : IAggregateRoot<string>
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
        Hospital Hospital { get; set; }
        [ProtoMember(7)]
        List<Record> Records { get; set; }
        [ProtoMember(8)]
        List<ITreatment> Treatments { get; set; }
        [ProtoMember(9)]
        DateTime? EntryDate { get; set; }
        [ProtoMember(10)]
        DateTime? CheckOutDate { get; set; }
        [ProtoMember(11)]
        Char Genre { get; set; }

        string GetCPF();
        void AddRecord(Record record);
        void SetLastTreatment();

        void AddTreatments(IList<ITreatment> treatments);
    }
}

using ProtoBuf;
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
        DbEnum? Hospital { get; set; }
        [ProtoMember(7)]
        List<RecordDTO> Records { get; set; }
        [ProtoMember(8)]
        List<ITreatmentDTO> Treatments { get; set; }
        [ProtoMember(9)]
        DateTime? EntryDate { get; set; }
        [ProtoMember(10)]
        DateTime? CheckOutDate { get; set; }

        string GetCPF();
        void AddRecord(RecordDTO record);
        void SetLastTreatment();

        void AddTreatments(IList<ITreatmentDTO> treatments);
    }
}

using System.Linq;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EHR.CoreShared
{

    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public class PatientDTO : IPatientDTO
    {
        [ProtoMember(1)]
        public virtual string Id { get; set; }

        [ProtoMember(2)]
        public virtual string Name { get; set; }

        [ProtoMember(3)]
        public virtual DateTime? DateBirthday { get; set; }

        [ProtoMember(4)]
        public virtual string CPF { get; set; }

        [ProtoMember(5)]
        public virtual string Identity { get; set; }

        [ProtoMember(6)]
        public virtual DbEnum? Hospital { get; set; }

        [ProtoMember(7)]
        public virtual List<RecordDTO> Records { get; set; }

        [ProtoMember(8)]
        public virtual List<ITreatmentDTO> Treatments { get; set; }

        [ProtoMember(2)]
        public DateTime? EntryDate { get; set; }

        [ProtoMember(3)]
        public DateTime? CheckOutDate { get; set; }

        public void SetLastTreatment()
        {
            if (Treatments != null && Treatments.Count > 0)
            {
                var treatment = Treatments.OrderByDescending(t => t.CheckOutDate).FirstOrDefault();
                this.EntryDate = treatment.EntryDate;
                this.CheckOutDate = treatment.CheckOutDate;
                this.Hospital = treatment.Hospital;
            }
        }

        public PatientDTO()
        {
            Records = new List<RecordDTO>();
            Treatments = new List<ITreatmentDTO>();
        }

        public virtual string GetCPF()
        {
            return Regex.Replace(CPF, "[^0-9]", string.Empty);
        }

        public virtual void AddRecord(RecordDTO record)
        {
            if (Records == null)
                Records = new List<RecordDTO>();

            Records.Add(record);
        }


        public virtual void AddTreatments(IList<ITreatmentDTO> treatments)
        {
            if (Treatments == null)
                Treatments = new List<ITreatmentDTO>();

            Treatments.AddRange(treatments);
        }
    }

    public enum HospitalPatientEnum : short
    {
        QuintaDor = 1,
        NiteroiDor,
        CopaDor,
        BarraDor
    }
}
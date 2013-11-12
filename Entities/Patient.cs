using System.Linq;
using EHR.CoreShared.Interfaces;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EHR.CoreShared.Entities
{

    [Serializable]
    [ProtoContract(SkipConstructor = true)]
    public class Patient : IPatient
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
        public virtual List<Record> Records { get; set; }

        [ProtoMember(8)]
        public virtual List<ITreatment> Treatments { get; set; }

        [ProtoMember(2)]
        public virtual DateTime? EntryDate { get; set; }

        [ProtoMember(3)]
        public virtual DateTime? CheckOutDate { get; set; }

        [ProtoMember(9)]
        public char Genre { get; set; }

        public virtual void SetLastTreatment()
        {
            if (Treatments != null && Treatments.Count > 0)
            {
                var treatment = Treatments.OrderByDescending(t => t.CheckOutDate).FirstOrDefault();
                EntryDate = treatment.EntryDate;
                CheckOutDate = treatment.CheckOutDate;
                Hospital = treatment.Hospital.Key;
            }
        }

        public Patient()
        {
            Records = new List<Record>();
            Treatments = new List<ITreatment>();
        }

        public virtual string GetCPF()
        {
            return Regex.Replace(CPF, "[^0-9]", string.Empty);
        }

        public virtual void AddRecord(Record record)
        {
            if (Records == null)
                Records = new List<Record>();

            Records.Add(record);
        }


        public virtual void AddTreatments(IList<ITreatment> treatments)
        {
            if (Treatments == null)
                Treatments = new List<ITreatment>();

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
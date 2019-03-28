using System;
using System.Collections.Generic;
using SQLite;

namespace CCAgenda.DL
{
    public class Clinic
    {
        public Clinic()
        {
            ClinWorkDays = new List<WorkDays>();
            ClinName = String.Empty;
            ClinRegistry = String.Empty;
            ClinOwner = String.Empty;
        }

        public List<WorkDays> ClinWorkDays { get; set; }
        public String ClinName { get; set; }
        public String ClinRegistry { get; set; }
        public String ClinOwner { get; set; }

        public struct WorkDays
        {
            public String Day { get; set; }
            public DateTime OpenTime { get; set; }
            public DateTime CloseTime { get; set; }
        }
    }
}

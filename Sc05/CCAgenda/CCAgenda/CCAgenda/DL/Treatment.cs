using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Treatment
    {
        private Int32 treatmentID;
        private String treatmentName;

        /// <summary>In Minutes
        /// </summary>
        private Int32 treatmentDuration;
        /// <summary>s - seconds /
        /// m - minutes /
        /// h - hours /
        /// d - days 
        /// </summary>
        private Char treatmentDurationTime;

        public Treatment()
        {
            this.treatmentName = String.Empty;
        }

        public int TreatmentID { get => treatmentID; set => treatmentID = value; }
        public string TreatmentName { get => treatmentName; set => treatmentName = value; }
        public int TreatmentDuration { get => treatmentDuration; set => treatmentDuration = value; }
        public char TreatmentDurationTime { get => treatmentDurationTime; set => treatmentDurationTime = value; }
    }
}

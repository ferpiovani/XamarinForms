using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Patient
    {
        private Int32 patientID;
        private String patientName;
        private String patientOccupation;
        private DateTime patientBirthday;
        private Social patientSocial;
        private Address patientAddress;
        private Int32 patientRecordID;

        public Patient()
        {
            this.patientName = String.Empty;
            this.patientOccupation = String.Empty;
            this.patientSocial = new Social();
            this.patientAddress = new Address();
        }

        public int PatientID { get => patientID; set => patientID = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientOccupation { get => patientOccupation; set => patientOccupation = value; }
        public DateTime PatientBirthday { get => patientBirthday; set => patientBirthday = value; }
        public Social PatientSocial { get => patientSocial; set => patientSocial = value; }
        public Address PatientAddress { get => patientAddress; set => patientAddress = value; }
        public Int32 PatientRecord { get => patientRecordID; set => patientRecordID = value; }
    }
}

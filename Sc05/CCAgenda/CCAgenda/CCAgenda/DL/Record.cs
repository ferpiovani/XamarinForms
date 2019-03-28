using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Record
    {
        // Prontuario, registra as condições iniciais do paciente, qual os sintomas, resultados das sessoes e etc

        private Int32 recordID;
        private Int32 recordPatient;
        private String recordComplaint;
        private String recordDiagnosis;
        private String recordPlan;
        private Boolean recordActive;

        public Record()
        {
            this.recordComplaint = String.Empty;
            this.recordDiagnosis = String.Empty;
            this.recordPlan = String.Empty;
        }

        public int RecordID { get => recordID; set => recordID = value; }
        public int RecordPatient { get => recordPatient; set => recordPatient = value; }
        public string RecordComplaint { get => recordComplaint; set => recordComplaint = value; }
        public string RecordDiagnosis { get => recordDiagnosis; set => recordDiagnosis = value; }
        public string RecordPlan { get => recordPlan; set => recordPlan = value; }
        public Boolean RecordActive { get => recordActive; set => recordActive = value; }
    }
}

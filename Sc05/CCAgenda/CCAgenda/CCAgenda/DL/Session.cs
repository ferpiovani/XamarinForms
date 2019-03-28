using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Session
    {
        public Session()
        {
            SessPatient = new Patient();
            SessDate = new DateTime();
            SessPhysician = new Physician();
        }

        public Patient SessPatient { get; set; }
        public DateTime SessDate { get; set; }
        public Physician SessPhysician { get; set; }
        public String Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class DailyRoutine
    {
        public DailyRoutine()
        {
            DaRoDate = new DateTime();
            DaRoNotes = String.Empty;
        }

        public DateTime DaRoDate { get; set; }
        public Int32 DaRoSessions { get; set; }
        public Int32 DaRoBusyTime { get; set; }
        public String DaRoNotes { get; set; }
        public Boolean DaRoIsFull { get; set; }
    }
}

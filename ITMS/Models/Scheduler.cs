using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.Models
{
    class Scheduler
    {
        public int SchedID { get; set; }
        public string EventTime { get; set; }
        public string EventName { get; set; }

        public string EventDay { get; set; }
       
        public string AudioFile { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.KMS
{
    public class KKHLocalCase : KKHObject
    {
        public String CaseNumber;
        public List<DateTime> TimeOpen;
        public List<DateTime> TimeClose;
        public List<KKHRecord> RecordList;
        public List<KKHRecord> PICList; // Person-in-charge
    }
}

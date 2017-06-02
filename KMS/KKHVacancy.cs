using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.KMS
{
    public class KKHVacancy : KKHObject
    {
        public KKHPatienten Patient;

        public List<DateTime> TimeIn;
        public List<DateTime> TimeOut;

        public KKHVacancy()
        {
            KKHPatienten p = new KKHPatienten();
            KKHPatientenError error = p.setKrankenkasseID("ABC123");

            switch (error)
            {
                case KKHPatientenError.NO_ERROR:
                    break;
                case KKHPatientenError.LENGTH_NO_MATCH:
                    break;
                case KKHPatientenError.FORMAT_NO_MATCH:
                    break;
                default:
                    break;
            }
        }
    }
}

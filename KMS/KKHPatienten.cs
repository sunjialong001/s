using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.KMS
{
    // enumeration 列舉, "for example"
    public enum KKHPatientenError
    {
        NO_ERROR,
        LENGTH_NO_MATCH,
        FORMAT_NO_MATCH
    }

    public class KKHPatienten : KKHPerson
    {
        protected String KrankenkasseID;

        public List<KKHLocalCase> LocalCaseList;

        public KKHPatientenError setKrankenkasseID(string input)
        {
            if (input.Length == 8)
            {
                this.KrankenkasseID = input;
                return KKHPatientenError.NO_ERROR;
            }
            else
            {
                return KKHPatientenError.LENGTH_NO_MATCH;
            }
        }
    }
}

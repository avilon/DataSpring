using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account : IDataReader
    {
        public string Id { get; set; }
        public string BillCycle { get; set; }
        public string CisDivision { get; set; }
        public DateTime SetupDate { get; set; }
        public string MailingPremId { get; set; }

        public void Read(string value)
        {
            string[] parts = value.Split(';');
            if (parts.Count() == 5)
            {
                Id = parts[0].Replace('"', ' ').Trim();
                BillCycle = parts[1].Replace('"', ' ').Trim();
                SetupDate = DateTime.Parse(parts[2].Replace('"', ' ').Trim());
                
            }
        }
    }
}

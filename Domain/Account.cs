using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;

namespace Domain
{
    public class Account : Entity
    {
        public string Id { get; set; }
        public string BillCycle { get; set; }
        public string CisDivision { get; set; }
        public DateTime SetupDate { get; set; }
        public string MailingPremId { get; set; }

        public override void Read(string value)
        {
            try
            {
                string[] parts = value.Split(';');
                if (parts.Count() == 5)
                {
                    Id = parts[0].Replace('"', ' ').Trim();
                    BillCycle = parts[1].Replace('"', ' ').Trim();
                    SetupDate = DateTime.Parse(parts[2].Replace('"', ' ').Trim());
                    CisDivision = parts[3].Replace('"', ' ').Trim();
                    MailingPremId = parts[4].Replace('"', ' ').Trim();
                }
            }
            catch (Exception e)
            {
                logger.Error("Ошибка парсига, строка: " + value);
                logger.Error(e.Message);
            }
        }

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    }
}

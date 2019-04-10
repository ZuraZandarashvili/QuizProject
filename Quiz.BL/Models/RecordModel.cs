using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.BL.Models
{
   public class RecordModel
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime Time { get; set; }
        public string Info => PlayerName.PadRight(15) + Score.ToString();
    }
}

using System;

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

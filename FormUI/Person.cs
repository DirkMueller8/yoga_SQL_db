using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Session
    {
        public int ID{ get; set; }
        public DateTime Date_S { get; set; }
        public bool S_1_1 { get; set; }
        public bool S_1_2 { get; set; }
        public bool S_1_3 { get; set; }
        public bool S_2_1 { get; set; }
        public bool S_2_2 { get; set; }
        public bool S_2_3 { get; set; }

        public string FullInfo
        {
            get { return $" {Date_S.ToString("dd/MM/yyyy")} S1: {S_1_1} S2: {S_1_2} S3: {S_1_3} S1: {S_2_1 } S2: {S_2_2} S3: {S_2_3}"; }
        }

    }
}

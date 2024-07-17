using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Result
    {
        public TimeDetail Time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public BPIDetails BPI { get; set; }

        public class TimeDetail
        {
            public String updated { get; set; }
            public String updatedISO { get; set; }
            public String updateduk { get; set; }
        }

        public class Currency
        {
            public string Code { get; set; }
            public string Symbol { get; set; }
            public string Rate { get; set; }
            public string Description { get; set; }
            public double RateFloat { get; set; }
        }

        public class BPIDetails
        {
            public Currency USD { get; set; }
            public Currency GBP { get; set; }
            public Currency EUR { get; set; }
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team5
{
    public class StatusUpdate
    {
        public string Title{ get; set; }
        public string Text { get; set; }
        public DateTime TimeUploaded { get; set; } = DateTime.Now;

    }
}

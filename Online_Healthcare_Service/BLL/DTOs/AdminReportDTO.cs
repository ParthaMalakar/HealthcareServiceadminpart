﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminReportDTO
    {
        public int ReportId { get; set; }
        public string sender { get; set; }
        public string Receiver { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime Report_Time { get; set; }
        public string Status { get; set; }
    }
}

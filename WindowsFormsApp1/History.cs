﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class History
    {
        public int Hist_ID { get; set; }
        public OperationEnum Hist_Action { get; set; }
        public string Hist_Value { get; set; }
    }
}

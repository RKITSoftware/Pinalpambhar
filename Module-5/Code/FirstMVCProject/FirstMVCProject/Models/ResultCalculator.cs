using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCProject.Models
{
    public class ResultCalculator
    {
        public int OperatingSystem { get; set; }
        public int CPP { get; set; }
        public int ComputerNetwork { get; set; }
        public int Math { get; set; }
        public int CompilerDesign { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsApplication1
{
    public class ProjCodeHandler
    {
        public string ProjectCode { get; set; }

        public List<string> ProjectCodes { get; set; }

        public double ProjCodeHours { get; set; }

        public double TotProjCodeHours { get; set; }

        public Dictionary<string, double> ProjectHourPairs { get; set; }

        public int rchBoxIndex { get; set; }


    }
}

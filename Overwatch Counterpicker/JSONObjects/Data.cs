using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overwatch_Counterpicker.JSONObjects
{
    public class Data
    {
        public string creator { get; set; } = "Unknown";
        public string link { get; set; } = "";
        public int[,] data { get; set; } = new int[,] {};
    }
}

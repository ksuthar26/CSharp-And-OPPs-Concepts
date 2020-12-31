using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum Season : int
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }
    public enum Gender1 : short
    {
        Unknown,
        Male,
        Female
    }
    public class Enums
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}

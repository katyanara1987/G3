using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    public class Country
    {
        public Country() 
        { 
        }
        public Country(string name, bool isTelenorSupported)
        {
            Name = name;
            IsTelenorSupported = isTelenorSupported;
        }
        public string Name { get; set; }
        public Boolean IsTelenorSupported { get; set; }
    }
}

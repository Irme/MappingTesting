using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace MappingTesting.src
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class Person
    {
        public int? age { get; set; }
        public string? name { get; set; }
        public string? hobby { get; set; }
        public int? id { get; set; } 
        public string? job { get; set; }

    }
}

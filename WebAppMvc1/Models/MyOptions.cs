using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvc1.Models
{
    public class MyOptions
    {
        public MyOptions()
        {
            Id = 1;
            Name = "refuge";
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}

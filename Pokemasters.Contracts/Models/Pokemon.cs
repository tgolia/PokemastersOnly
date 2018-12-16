using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemasters.Contracts.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string PrimaryType { get; set; }
        public string SecondaryType { get; set; }

    }
}
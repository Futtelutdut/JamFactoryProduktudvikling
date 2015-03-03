using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamFactory.Model
{
    class Ingredient
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Ingredient(string name, int id)
        {
            Name = name;
            ID = id; 
        }
    }
}

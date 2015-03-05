using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamFactory.Controller
{
    class Controller
    {
        Database.ProduktudviklingDBF pDBF = new Database.ProduktudviklingDBF();
        public List<string> GetIngredients()
        {
            List<string> ingredientlist = new List<string>();
            foreach (Model.Ingredient i in pDBF.GetAllIngredients())
            {
                ingredientlist.Add(i.Name);
            }

            return ingredientlist;
        }

    }
}

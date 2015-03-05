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
        List<string> allberries = new List<string>() {"Jordbær"};
        List<string> allingredients = new List<string>() {"Lakrids"};
        public List<string> GetIngredients(int determinator)
        {
            List<string> berrylist = new List<string>();
            List<string> ingredientlist = new List<string>();
            foreach (Model.Ingredient i in pDBF.GetAllIngredients())
            {
                foreach (string b in allberries) 
                {
                    if (b == i.Name) 
                    {
                        berrylist.Add(i.Name);
                    }
                }
                foreach (string s in allingredients)
                {
                    if (s == i.Name)
                    {
                        ingredientlist.Add(i.Name);
                    }
                }
            }

            if (determinator == 0)
            {
                return berrylist;
            }
            else
            {
                return ingredientlist;
            }
        }

    }
}

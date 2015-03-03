using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JamFactory.Controller.Database
{
    class ProduktudviklingDBF
    {
        string DBConnectionString = "Server=ealdb1.eal.local;" + "Database=EJL20_DB;" + "User Id=ejl20_usr;" + "Password=Baz1nga20;";

        public List<Model.Ingredient> GetAllIngredients()
        {
            List<Model.Ingredient> ingredients = new List<Model.Ingredient>();

            SqlConnection SqlConnection = new SqlConnection(DBConnectionString);

            try
            {
                SqlConnection.Open();

                SqlCommand cmd = new SqlCommand("0400_get_ingredient", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read() && rdr.HasRows)
                {
                    ingredients.Add(new Model.Ingredient(rdr["Name"].ToString(), int.Parse(rdr["ID"].ToString())));
                }
            }
            catch (SqlException e)
            {
                System.Windows.MessageBox.Show(e.Message);

            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }

            return ingredients;
        }
    }
}

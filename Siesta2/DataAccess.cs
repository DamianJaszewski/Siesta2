using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Siesta2
{
    public class DataAccess
    {

        public List<Recipe> GetAllRecipe(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Siesta")))
            {
                //var output = connection.Query<Recipe>($"SELECT * FROM Recipe WHERE Name = '{Name}'").ToList();
                var output = connection.Query<Recipe>("dbo.Recipe_GetAllRecipe").ToList();

                return output;
            }
        }
        public List<Recipe> GetRecipe(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Siesta")))
            {
                //var output = connection.Query<Recipe>($"SELECT * FROM Recipe WHERE Name = '{Name}'").ToList();
                var output = connection.Query<Recipe>("dbo.Recipe_GetByName @Name", new { Name = Name }).ToList();

                return output;
            }
        }

        public void InsertRecipe(string Name, string PreepTime, string Instruction)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Siesta")))
            {
                //Recipe newRecipe = new Recipe { Name = Name, PreepTime = Convert.ToInt32(PreepTime), Instruction = Instruction };
                //newRecipe.Name = Name;

                List<Recipe> recipe = new List<Recipe>();

                recipe.Add(new Recipe { Name = Name, PreepTime = Convert.ToInt32(PreepTime), Instruction = Instruction });

                connection.Execute("dbo.Recipe_Insert @Name, @PreepTime, @Instruction", recipe);
            }
        }

        public List<Recipe> GetRecipeDetails(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Siesta")))
            {
                //var output = connection.Query<Recipe>($"SELECT * FROM Recipe WHERE Name = '{Name}'").ToList();
                var output = connection.Query<Recipe>("dbo.Recipe_GetByName @Name", new { Name = Name }).ToList();

                return output;
            }
        }
    }
}

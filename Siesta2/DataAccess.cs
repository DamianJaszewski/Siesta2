﻿using System;
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
        public List<Recipe> GetRecipe(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Siesta")))
            {
               var output = connection.Query<Recipe>($"select Name * Recipe where Name = '{Name}'").ToList();
               return output;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siesta2
{
    public partial class Dashboard : Form
    {

        List<Recipe> recipes = new List<Recipe>();
        List<Recipe> recipeDetails = new List<Recipe>();
        public Dashboard()
        {
            InitializeComponent();
            AllRecipe();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            RecipeListbox.DataSource = recipes;
            RecipeListbox.DisplayMember = "FullInfo";
            InstructionListbox.DataSource = recipeDetails;
            InstructionListbox.DisplayMember = "RecipeDetails";

        }

        private void AllRecipe()
        {
            DataAccess db = new DataAccess();

            recipes = db.GetAllRecipe();

            UpdateBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            recipes = db.GetRecipe(RecipeText.Text);
            recipeDetails = db.GetRecipeDetails(RecipeText.Text);

            UpdateBinding();
        }

        private void InsertRecipeBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertRecipe(NameInsTxt.Text, PreepTimeInsTxt.Text, InstructionInsTxt.Text);

            NameInsTxt.Text = "";
            PreepTimeInsTxt.Text = "";
            InstructionInsTxt.Text = "";
        }

        private void RecipeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
           

            UpdateBinding();
        }

        /*
        private void RecipeDetails()
        {
            DataAccess db = new DataAccess();

            recipeDetails = db.GetRecipeDetails(Convert.ToString(RecipeListbox.SelectedValue));

            UpdateBinding();

        }
        */
    }
}

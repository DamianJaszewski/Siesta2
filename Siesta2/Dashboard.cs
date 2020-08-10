using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        List<Ingredient> ingredient = new List<Ingredient>();
        List<Recipe> recipeDetails = new List<Recipe>();
        List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();

        public Dashboard()
        {
            InitializeComponent();
            AllRecipe();
            AllIngredient();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            RecipeListbox.DataSource = recipes;
            RecipeListbox.DisplayMember = "FullInfo";
            AllIngredientListBox.DataSource = ingredient;
            AllIngredientListBox.DisplayMember = "IngredientInfo";
            InstructionListbox.DataSource = recipeDetails;
            InstructionListbox.DisplayMember = "RecipeDetails";
            IngredientListbox.DataSource = recipeIngredients;
            IngredientListbox.DisplayMember = "IngredientInfo";

        }

        private void AllRecipe()
        {
            DataAccess db = new DataAccess();

            recipes = db.GetAllRecipe();

            UpdateBinding();
        }

        private void AllIngredient()
        {
            DataAccess db = new DataAccess();

            ingredient = db.GetAllIngredient();

            UpdateBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            recipes = db.GetRecipe(RecipeText.Text);
            recipeDetails = db.GetRecipeIngredient(RecipeText.Text);
            recipeIngredients = db.GetRecipeDetails(RecipeText.Text);

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

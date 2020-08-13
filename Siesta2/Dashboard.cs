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
        List<Ingredient> recipeIngredients =new List<Ingredient>();
        List<Measure> measure = new List<Measure>();
        List<RecipeIngredient> quantity = new List<RecipeIngredient>();

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
            AllIngredientListBox.DisplayMember = "IngredientInfoName";
            InstructionListbox.DataSource = recipeDetails;
            InstructionListbox.DisplayMember = "RecipeDetails";
            IngredientListbox.DataSource = recipeIngredients;
            IngredientListbox.DisplayMember = "IngredientInfoName";
            MeasureListbox.DataSource = measure;
            MeasureListbox.DisplayMember = "MeasureInfo";
            QuantityListbox.DataSource = quantity;
            QuantityListbox.DisplayMember = "QuantityInfo";

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

            recipeDetails = db.GetRecipeIngredient(RecipeText.Text);
            recipeIngredients = db.GetRecipeDetails(RecipeText.Text);
            measure = db.GetMeasureDetails(RecipeText.Text);
            quantity = db.GetQuantityDetails(RecipeText.Text);

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

        private void InsertDetailsBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertRecipeDetails(QuantityInsTxt.Text, MeasureInsTxt.Text, NameInsTxt.Text, IngredientInsTxt.Text);

            QuantityInsTxt.Text = "";
            MeasureInsTxt.Text = "";
            NameInsTxt.Text = "";
            IngredientInsTxt.Text = "";
        }
    }
}

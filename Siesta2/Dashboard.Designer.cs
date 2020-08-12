namespace Siesta2
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipeListbox = new System.Windows.Forms.ListBox();
            this.RecipeText = new System.Windows.Forms.TextBox();
            this.RecipeLbl = new System.Windows.Forms.Label();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.NameInsLbl = new System.Windows.Forms.Label();
            this.NameInsTxt = new System.Windows.Forms.TextBox();
            this.PreepTimeInsLbl = new System.Windows.Forms.Label();
            this.PreepTimeInsTxt = new System.Windows.Forms.TextBox();
            this.InstructionInsLbl = new System.Windows.Forms.Label();
            this.InstructionInsTxt = new System.Windows.Forms.TextBox();
            this.InsertRecipeBtn = new System.Windows.Forms.Button();
            this.InstructionListbox = new System.Windows.Forms.ListBox();
            this.IngredientInsLbl = new System.Windows.Forms.Label();
            this.IngredientInsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityInsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MeasureInsTxt = new System.Windows.Forms.TextBox();
            this.InsertDetailsBtn = new System.Windows.Forms.Button();
            this.IngredientListbox = new System.Windows.Forms.ListBox();
            this.AllIngredientListBox = new System.Windows.Forms.ListBox();
            this.QuantityListbox = new System.Windows.Forms.ListBox();
            this.MeasureListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RecipeListbox
            // 
            this.RecipeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeListbox.FormattingEnabled = true;
            this.RecipeListbox.ItemHeight = 16;
            this.RecipeListbox.Location = new System.Drawing.Point(724, 28);
            this.RecipeListbox.Name = "RecipeListbox";
            this.RecipeListbox.Size = new System.Drawing.Size(307, 212);
            this.RecipeListbox.TabIndex = 0;
            this.RecipeListbox.SelectedIndexChanged += new System.EventHandler(this.RecipeListbox_SelectedIndexChanged);
            // 
            // RecipeText
            // 
            this.RecipeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeText.Location = new System.Drawing.Point(77, 9);
            this.RecipeText.Name = "RecipeText";
            this.RecipeText.Size = new System.Drawing.Size(225, 26);
            this.RecipeText.TabIndex = 1;
            // 
            // RecipeLbl
            // 
            this.RecipeLbl.AutoSize = true;
            this.RecipeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeLbl.Location = new System.Drawing.Point(12, 12);
            this.RecipeLbl.Name = "RecipeLbl";
            this.RecipeLbl.Size = new System.Drawing.Size(59, 20);
            this.RecipeLbl.TabIndex = 2;
            this.RecipeLbl.Text = "Recipe";
            // 
            // RecipeButton
            // 
            this.RecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeButton.Location = new System.Drawing.Point(219, 41);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(83, 26);
            this.RecipeButton.TabIndex = 3;
            this.RecipeButton.Text = "Search";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameInsLbl
            // 
            this.NameInsLbl.AutoSize = true;
            this.NameInsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameInsLbl.Location = new System.Drawing.Point(332, 28);
            this.NameInsLbl.Name = "NameInsLbl";
            this.NameInsLbl.Size = new System.Drawing.Size(51, 20);
            this.NameInsLbl.TabIndex = 5;
            this.NameInsLbl.Text = "Name";
            // 
            // NameInsTxt
            // 
            this.NameInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameInsTxt.Location = new System.Drawing.Point(433, 28);
            this.NameInsTxt.Name = "NameInsTxt";
            this.NameInsTxt.Size = new System.Drawing.Size(263, 23);
            this.NameInsTxt.TabIndex = 4;
            // 
            // PreepTimeInsLbl
            // 
            this.PreepTimeInsLbl.AutoSize = true;
            this.PreepTimeInsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreepTimeInsLbl.Location = new System.Drawing.Point(332, 60);
            this.PreepTimeInsLbl.Name = "PreepTimeInsLbl";
            this.PreepTimeInsLbl.Size = new System.Drawing.Size(89, 20);
            this.PreepTimeInsLbl.TabIndex = 7;
            this.PreepTimeInsLbl.Text = "Preep Time";
            // 
            // PreepTimeInsTxt
            // 
            this.PreepTimeInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreepTimeInsTxt.Location = new System.Drawing.Point(433, 60);
            this.PreepTimeInsTxt.Name = "PreepTimeInsTxt";
            this.PreepTimeInsTxt.Size = new System.Drawing.Size(263, 23);
            this.PreepTimeInsTxt.TabIndex = 6;
            // 
            // InstructionInsLbl
            // 
            this.InstructionInsLbl.AutoSize = true;
            this.InstructionInsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstructionInsLbl.Location = new System.Drawing.Point(332, 92);
            this.InstructionInsLbl.Name = "InstructionInsLbl";
            this.InstructionInsLbl.Size = new System.Drawing.Size(84, 20);
            this.InstructionInsLbl.TabIndex = 9;
            this.InstructionInsLbl.Text = "Instruction";
            // 
            // InstructionInsTxt
            // 
            this.InstructionInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstructionInsTxt.Location = new System.Drawing.Point(433, 89);
            this.InstructionInsTxt.Multiline = true;
            this.InstructionInsTxt.Name = "InstructionInsTxt";
            this.InstructionInsTxt.Size = new System.Drawing.Size(263, 152);
            this.InstructionInsTxt.TabIndex = 8;
            // 
            // InsertRecipeBtn
            // 
            this.InsertRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertRecipeBtn.Location = new System.Drawing.Point(336, 212);
            this.InsertRecipeBtn.Name = "InsertRecipeBtn";
            this.InsertRecipeBtn.Size = new System.Drawing.Size(85, 26);
            this.InsertRecipeBtn.TabIndex = 10;
            this.InsertRecipeBtn.Text = "Insert";
            this.InsertRecipeBtn.UseVisualStyleBackColor = true;
            this.InsertRecipeBtn.Click += new System.EventHandler(this.InsertRecipeBtn_Click);
            // 
            // InstructionListbox
            // 
            this.InstructionListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstructionListbox.FormattingEnabled = true;
            this.InstructionListbox.IntegralHeight = false;
            this.InstructionListbox.ItemHeight = 16;
            this.InstructionListbox.Location = new System.Drawing.Point(17, 246);
            this.InstructionListbox.Name = "InstructionListbox";
            this.InstructionListbox.Size = new System.Drawing.Size(285, 219);
            this.InstructionListbox.TabIndex = 13;
            // 
            // IngredientInsLbl
            // 
            this.IngredientInsLbl.AutoSize = true;
            this.IngredientInsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IngredientInsLbl.Location = new System.Drawing.Point(340, 268);
            this.IngredientInsLbl.Name = "IngredientInsLbl";
            this.IngredientInsLbl.Size = new System.Drawing.Size(81, 20);
            this.IngredientInsLbl.TabIndex = 15;
            this.IngredientInsLbl.Text = "Ingredient";
            // 
            // IngredientInsTxt
            // 
            this.IngredientInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IngredientInsTxt.Location = new System.Drawing.Point(344, 291);
            this.IngredientInsTxt.Name = "IngredientInsTxt";
            this.IngredientInsTxt.Size = new System.Drawing.Size(207, 23);
            this.IngredientInsTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(625, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Measure";
            // 
            // QuantityInsTxt
            // 
            this.QuantityInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuantityInsTxt.Location = new System.Drawing.Point(557, 291);
            this.QuantityInsTxt.Name = "QuantityInsTxt";
            this.QuantityInsTxt.Size = new System.Drawing.Size(37, 23);
            this.QuantityInsTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(541, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            // 
            // MeasureInsTxt
            // 
            this.MeasureInsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeasureInsTxt.Location = new System.Drawing.Point(600, 291);
            this.MeasureInsTxt.Name = "MeasureInsTxt";
            this.MeasureInsTxt.Size = new System.Drawing.Size(96, 23);
            this.MeasureInsTxt.TabIndex = 18;
            // 
            // InsertDetailsBtn
            // 
            this.InsertDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertDetailsBtn.Location = new System.Drawing.Point(644, 439);
            this.InsertDetailsBtn.Name = "InsertDetailsBtn";
            this.InsertDetailsBtn.Size = new System.Drawing.Size(52, 26);
            this.InsertDetailsBtn.TabIndex = 20;
            this.InsertDetailsBtn.Text = "Add";
            this.InsertDetailsBtn.UseVisualStyleBackColor = true;
            this.InsertDetailsBtn.Click += new System.EventHandler(this.InsertDetailsBtn_Click);
            // 
            // IngredientListbox
            // 
            this.IngredientListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IngredientListbox.FormattingEnabled = true;
            this.IngredientListbox.IntegralHeight = false;
            this.IngredientListbox.ItemHeight = 16;
            this.IngredientListbox.Location = new System.Drawing.Point(17, 73);
            this.IngredientListbox.Name = "IngredientListbox";
            this.IngredientListbox.Size = new System.Drawing.Size(147, 167);
            this.IngredientListbox.TabIndex = 21;
            // 
            // AllIngredientListBox
            // 
            this.AllIngredientListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllIngredientListBox.FormattingEnabled = true;
            this.AllIngredientListBox.ItemHeight = 16;
            this.AllIngredientListBox.Location = new System.Drawing.Point(724, 246);
            this.AllIngredientListBox.Name = "AllIngredientListBox";
            this.AllIngredientListBox.Size = new System.Drawing.Size(307, 212);
            this.AllIngredientListBox.TabIndex = 22;
            // 
            // QuantityListbox
            // 
            this.QuantityListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuantityListbox.FormattingEnabled = true;
            this.QuantityListbox.IntegralHeight = false;
            this.QuantityListbox.ItemHeight = 16;
            this.QuantityListbox.Location = new System.Drawing.Point(262, 74);
            this.QuantityListbox.Name = "QuantityListbox";
            this.QuantityListbox.Size = new System.Drawing.Size(40, 167);
            this.QuantityListbox.TabIndex = 23;
            // 
            // MeasureListbox
            // 
            this.MeasureListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeasureListbox.FormattingEnabled = true;
            this.MeasureListbox.IntegralHeight = false;
            this.MeasureListbox.ItemHeight = 16;
            this.MeasureListbox.Location = new System.Drawing.Point(170, 74);
            this.MeasureListbox.Name = "MeasureListbox";
            this.MeasureListbox.Size = new System.Drawing.Size(83, 167);
            this.MeasureListbox.TabIndex = 24;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 515);
            this.Controls.Add(this.MeasureListbox);
            this.Controls.Add(this.QuantityListbox);
            this.Controls.Add(this.AllIngredientListBox);
            this.Controls.Add(this.IngredientListbox);
            this.Controls.Add(this.InsertDetailsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeasureInsTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuantityInsTxt);
            this.Controls.Add(this.IngredientInsLbl);
            this.Controls.Add(this.IngredientInsTxt);
            this.Controls.Add(this.InstructionListbox);
            this.Controls.Add(this.InsertRecipeBtn);
            this.Controls.Add(this.InstructionInsLbl);
            this.Controls.Add(this.InstructionInsTxt);
            this.Controls.Add(this.PreepTimeInsLbl);
            this.Controls.Add(this.PreepTimeInsTxt);
            this.Controls.Add(this.NameInsLbl);
            this.Controls.Add(this.NameInsTxt);
            this.Controls.Add(this.RecipeButton);
            this.Controls.Add(this.RecipeLbl);
            this.Controls.Add(this.RecipeText);
            this.Controls.Add(this.RecipeListbox);
            this.Name = "Dashboard";
            this.Text = "Siesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RecipeListbox;
        private System.Windows.Forms.TextBox RecipeText;
        private System.Windows.Forms.Label RecipeLbl;
        private System.Windows.Forms.Button RecipeButton;
        private System.Windows.Forms.Label NameInsLbl;
        private System.Windows.Forms.TextBox NameInsTxt;
        private System.Windows.Forms.Label PreepTimeInsLbl;
        private System.Windows.Forms.TextBox PreepTimeInsTxt;
        private System.Windows.Forms.Label InstructionInsLbl;
        private System.Windows.Forms.TextBox InstructionInsTxt;
        private System.Windows.Forms.Button InsertRecipeBtn;
        private System.Windows.Forms.ListBox InstructionListbox;
        private System.Windows.Forms.Label IngredientInsLbl;
        private System.Windows.Forms.TextBox IngredientInsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityInsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MeasureInsTxt;
        private System.Windows.Forms.Button InsertDetailsBtn;
        private System.Windows.Forms.ListBox IngredientListbox;
        private System.Windows.Forms.ListBox AllIngredientListBox;
        private System.Windows.Forms.ListBox QuantityListbox;
        private System.Windows.Forms.ListBox MeasureListbox;
    }
}


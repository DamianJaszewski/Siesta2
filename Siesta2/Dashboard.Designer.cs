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
            this.SuspendLayout();
            // 
            // RecipeListbox
            // 
            this.RecipeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeListbox.FormattingEnabled = true;
            this.RecipeListbox.ItemHeight = 20;
            this.RecipeListbox.Location = new System.Drawing.Point(16, 73);
            this.RecipeListbox.Name = "RecipeListbox";
            this.RecipeListbox.Size = new System.Drawing.Size(295, 264);
            this.RecipeListbox.TabIndex = 0;
            // 
            // RecipeText
            // 
            this.RecipeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeText.Location = new System.Drawing.Point(77, 9);
            this.RecipeText.Name = "RecipeText";
            this.RecipeText.Size = new System.Drawing.Size(234, 26);
            this.RecipeText.TabIndex = 1;
            // 
            // RecipeLbl
            // 
            this.RecipeLbl.AutoSize = true;
            this.RecipeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeLbl.Location = new System.Drawing.Point(12, 15);
            this.RecipeLbl.Name = "RecipeLbl";
            this.RecipeLbl.Size = new System.Drawing.Size(59, 20);
            this.RecipeLbl.TabIndex = 2;
            this.RecipeLbl.Text = "Recipe";
            // 
            // RecipeButton
            // 
            this.RecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipeButton.Location = new System.Drawing.Point(113, 41);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(83, 26);
            this.RecipeButton.TabIndex = 3;
            this.RecipeButton.Text = "Search";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}


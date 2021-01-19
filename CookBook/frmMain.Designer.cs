namespace CookBook
{
    partial class frmMain
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
            this.cookBookDataSet = new CookBook.CookBookDataSet();
            this.lblRetete = new System.Windows.Forms.Label();
            this.lstRetete = new System.Windows.Forms.ListBox();
            this.lstIngrediente = new System.Windows.Forms.ListBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnAddReteta = new System.Windows.Forms.Button();
            this.txtNumeReteta = new System.Windows.Forms.TextBox();
            this.btnUpdateNumeReteta = new System.Windows.Forms.Button();
            this.lstToateIngredientele = new System.Windows.Forms.ListBox();
            this.lblToateIngredientele = new System.Windows.Forms.Label();
            this.btnAdaugaInReteta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookBookDataSet
            // 
            this.cookBookDataSet.DataSetName = "CookBookDataSet";
            this.cookBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRetete
            // 
            this.lblRetete.AutoSize = true;
            this.lblRetete.Location = new System.Drawing.Point(34, 100);
            this.lblRetete.Name = "lblRetete";
            this.lblRetete.Size = new System.Drawing.Size(39, 13);
            this.lblRetete.TabIndex = 2;
            this.lblRetete.Text = "Retete";
            // 
            // lstRetete
            // 
            this.lstRetete.FormattingEnabled = true;
            this.lstRetete.Location = new System.Drawing.Point(37, 116);
            this.lstRetete.Name = "lstRetete";
            this.lstRetete.Size = new System.Drawing.Size(151, 277);
            this.lstRetete.TabIndex = 3;
            this.lstRetete.SelectedIndexChanged += new System.EventHandler(this.lstRetete_SelectedIndexChanged);
            // 
            // lstIngrediente
            // 
            this.lstIngrediente.FormattingEnabled = true;
            this.lstIngrediente.Location = new System.Drawing.Point(37, 429);
            this.lstIngrediente.Name = "lstIngrediente";
            this.lstIngrediente.Size = new System.Drawing.Size(151, 251);
            this.lstIngrediente.TabIndex = 5;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(34, 413);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(95, 13);
            this.lblIngredient.TabIndex = 4;
            this.lblIngredient.Text = "Ingrediente Reteta";
            // 
            // btnAddReteta
            // 
            this.btnAddReteta.Location = new System.Drawing.Point(37, 39);
            this.btnAddReteta.Name = "btnAddReteta";
            this.btnAddReteta.Size = new System.Drawing.Size(151, 23);
            this.btnAddReteta.TabIndex = 6;
            this.btnAddReteta.Text = "Reteta Noua";
            this.btnAddReteta.UseVisualStyleBackColor = true;
            // 
            // txtNumeReteta
            // 
            this.txtNumeReteta.Location = new System.Drawing.Point(37, 13);
            this.txtNumeReteta.Name = "txtNumeReteta";
            this.txtNumeReteta.Size = new System.Drawing.Size(151, 20);
            this.txtNumeReteta.TabIndex = 7;
            // 
            // btnUpdateNumeReteta
            // 
            this.btnUpdateNumeReteta.Location = new System.Drawing.Point(37, 68);
            this.btnUpdateNumeReteta.Name = "btnUpdateNumeReteta";
            this.btnUpdateNumeReteta.Size = new System.Drawing.Size(151, 23);
            this.btnUpdateNumeReteta.TabIndex = 8;
            this.btnUpdateNumeReteta.Text = "Actualizeaza Nume Reteta";
            this.btnUpdateNumeReteta.UseVisualStyleBackColor = true;
            // 
            // lstToateIngredientele
            // 
            this.lstToateIngredientele.FormattingEnabled = true;
            this.lstToateIngredientele.Location = new System.Drawing.Point(254, 116);
            this.lstToateIngredientele.Name = "lstToateIngredientele";
            this.lstToateIngredientele.Size = new System.Drawing.Size(151, 277);
            this.lstToateIngredientele.TabIndex = 10;
            // 
            // lblToateIngredientele
            // 
            this.lblToateIngredientele.AutoSize = true;
            this.lblToateIngredientele.Location = new System.Drawing.Point(251, 100);
            this.lblToateIngredientele.Name = "lblToateIngredientele";
            this.lblToateIngredientele.Size = new System.Drawing.Size(99, 13);
            this.lblToateIngredientele.TabIndex = 9;
            this.lblToateIngredientele.Text = "Toate Ingredientele";
            // 
            // btnAdaugaInReteta
            // 
            this.btnAdaugaInReteta.Location = new System.Drawing.Point(254, 399);
            this.btnAdaugaInReteta.Name = "btnAdaugaInReteta";
            this.btnAdaugaInReteta.Size = new System.Drawing.Size(151, 23);
            this.btnAdaugaInReteta.TabIndex = 11;
            this.btnAdaugaInReteta.Text = "Adauga in reteta";
            this.btnAdaugaInReteta.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 729);
            this.Controls.Add(this.btnAdaugaInReteta);
            this.Controls.Add(this.lstToateIngredientele);
            this.Controls.Add(this.lblToateIngredientele);
            this.Controls.Add(this.btnUpdateNumeReteta);
            this.Controls.Add(this.txtNumeReteta);
            this.Controls.Add(this.btnAddReteta);
            this.Controls.Add(this.lstIngrediente);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.lstRetete);
            this.Controls.Add(this.lblRetete);
            this.Name = "frmMain";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookBookDataSet cookBookDataSet;
        private System.Windows.Forms.Label lblRetete;
        private System.Windows.Forms.ListBox lstRetete;
        private System.Windows.Forms.ListBox lstIngrediente;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnAddReteta;
        private System.Windows.Forms.TextBox txtNumeReteta;
        private System.Windows.Forms.Button btnUpdateNumeReteta;
        private System.Windows.Forms.ListBox lstToateIngredientele;
        private System.Windows.Forms.Label lblToateIngredientele;
        private System.Windows.Forms.Button btnAdaugaInReteta;
    }
}


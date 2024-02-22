namespace Pokeapi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokemones = new System.Windows.Forms.DataGridView();
            this.nombrePokemon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPokedex = new System.Windows.Forms.Button();
            this.TxtBuscarPokemon = new System.Windows.Forms.TextBox();
            this.BtnBuscarPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemones
            // 
            this.dgvPokemones.AllowUserToAddRows = false;
            this.dgvPokemones.AllowUserToDeleteRows = false;
            this.dgvPokemones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePokemon});
            this.dgvPokemones.Location = new System.Drawing.Point(12, 12);
            this.dgvPokemones.MultiSelect = false;
            this.dgvPokemones.Name = "dgvPokemones";
            this.dgvPokemones.ReadOnly = true;
            this.dgvPokemones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemones.Size = new System.Drawing.Size(776, 365);
            this.dgvPokemones.TabIndex = 0;
            this.dgvPokemones.Click += new System.EventHandler(this.dgvPokemones_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.HeaderText = "Nombre";
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.ReadOnly = true;
            // 
            // btnPokedex
            // 
            this.btnPokedex.Location = new System.Drawing.Point(661, 392);
            this.btnPokedex.Name = "btnPokedex";
            this.btnPokedex.Size = new System.Drawing.Size(127, 46);
            this.btnPokedex.TabIndex = 1;
            this.btnPokedex.Text = "Acceder pokedex";
            this.btnPokedex.UseVisualStyleBackColor = true;
            this.btnPokedex.Click += new System.EventHandler(this.btnPokedex_Click);
            // 
            // TxtBuscarPokemon
            // 
            this.TxtBuscarPokemon.Location = new System.Drawing.Point(12, 406);
            this.TxtBuscarPokemon.Name = "TxtBuscarPokemon";
            this.TxtBuscarPokemon.Size = new System.Drawing.Size(224, 20);
            this.TxtBuscarPokemon.TabIndex = 2;
            // 
            // BtnBuscarPokemon
            // 
            this.BtnBuscarPokemon.Location = new System.Drawing.Point(263, 406);
            this.BtnBuscarPokemon.Name = "BtnBuscarPokemon";
            this.BtnBuscarPokemon.Size = new System.Drawing.Size(75, 20);
            this.BtnBuscarPokemon.TabIndex = 3;
            this.BtnBuscarPokemon.Text = "Buscar";
            this.BtnBuscarPokemon.UseVisualStyleBackColor = true;
            this.BtnBuscarPokemon.Click += new System.EventHandler(this.BtnBuscarPokemon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscarPokemon);
            this.Controls.Add(this.TxtBuscarPokemon);
            this.Controls.Add(this.btnPokedex);
            this.Controls.Add(this.dgvPokemones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PokeApi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePokemon;
        private System.Windows.Forms.Button btnPokedex;
        private System.Windows.Forms.TextBox TxtBuscarPokemon;
        private System.Windows.Forms.Button BtnBuscarPokemon;
    }
}


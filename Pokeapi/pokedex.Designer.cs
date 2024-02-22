namespace Pokeapi
{
    partial class pokedex
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
            this.PbPokemon1 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.PbPokemon2 = new System.Windows.Forms.PictureBox();
            this.PbPokemon3 = new System.Windows.Forms.PictureBox();
            this.PbPokemon4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon4)).BeginInit();
            this.SuspendLayout();
            // 
            // PbPokemon1
            // 
            this.PbPokemon1.Location = new System.Drawing.Point(12, 54);
            this.PbPokemon1.Name = "PbPokemon1";
            this.PbPokemon1.Size = new System.Drawing.Size(104, 95);
            this.PbPokemon1.TabIndex = 0;
            this.PbPokemon1.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(266, 12);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(522, 415);
            this.txtDescripcion.TabIndex = 1;
            // 
            // PbPokemon2
            // 
            this.PbPokemon2.Location = new System.Drawing.Point(142, 54);
            this.PbPokemon2.Name = "PbPokemon2";
            this.PbPokemon2.Size = new System.Drawing.Size(104, 95);
            this.PbPokemon2.TabIndex = 6;
            this.PbPokemon2.TabStop = false;
            // 
            // PbPokemon3
            // 
            this.PbPokemon3.Location = new System.Drawing.Point(12, 176);
            this.PbPokemon3.Name = "PbPokemon3";
            this.PbPokemon3.Size = new System.Drawing.Size(104, 95);
            this.PbPokemon3.TabIndex = 7;
            this.PbPokemon3.TabStop = false;
            // 
            // PbPokemon4
            // 
            this.PbPokemon4.Location = new System.Drawing.Point(142, 176);
            this.PbPokemon4.Name = "PbPokemon4";
            this.PbPokemon4.Size = new System.Drawing.Size(104, 95);
            this.PbPokemon4.TabIndex = 8;
            this.PbPokemon4.TabStop = false;
            // 
            // pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbPokemon4);
            this.Controls.Add(this.PbPokemon3);
            this.Controls.Add(this.PbPokemon2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.PbPokemon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pokedex";
            this.Text = "pokedex";
            this.Load += new System.EventHandler(this.pokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPokemon4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbPokemon1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox PbPokemon2;
        private System.Windows.Forms.PictureBox PbPokemon3;
        private System.Windows.Forms.PictureBox PbPokemon4;
    }
}
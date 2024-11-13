namespace Gramatica
{
    partial class dtgvErrores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.dtgTokens = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(12, 12);
            this.txtPalabras.Multiline = true;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(475, 618);
            this.txtPalabras.TabIndex = 1;
            // 
            // btnRevisar
            // 
            this.btnRevisar.Location = new System.Drawing.Point(297, 656);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(190, 43);
            this.btnRevisar.TabIndex = 2;
            this.btnRevisar.Text = "REVISAR LÉXICO";
            this.btnRevisar.UseVisualStyleBackColor = true;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // dtgTokens
            // 
            this.dtgTokens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTokens.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgTokens.Location = new System.Drawing.Point(509, 12);
            this.dtgTokens.Name = "dtgTokens";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTokens.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgTokens.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTokens.Size = new System.Drawing.Size(475, 618);
            this.dtgTokens.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "REVISAR SINTÁCTICO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgTokens);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.txtPalabras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dtgvErrores";
            this.Text = "Gramatica";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.DataGridView dtgTokens;
        private System.Windows.Forms.Button button1;
    }
}


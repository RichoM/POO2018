namespace _2018_EjercicioConstructores
{
    partial class Form1
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
            this.altaCampoButton = new System.Windows.Forms.Button();
            this.camposGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.camposGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // altaCampoButton
            // 
            this.altaCampoButton.Location = new System.Drawing.Point(12, 12);
            this.altaCampoButton.Name = "altaCampoButton";
            this.altaCampoButton.Size = new System.Drawing.Size(165, 40);
            this.altaCampoButton.TabIndex = 0;
            this.altaCampoButton.Text = "Alta de campo...";
            this.altaCampoButton.UseVisualStyleBackColor = true;
            this.altaCampoButton.Click += new System.EventHandler(this.altaCampoButton_Click);
            // 
            // camposGrid
            // 
            this.camposGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camposGrid.Location = new System.Drawing.Point(184, 13);
            this.camposGrid.Name = "camposGrid";
            this.camposGrid.Size = new System.Drawing.Size(530, 360);
            this.camposGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 501);
            this.Controls.Add(this.camposGrid);
            this.Controls.Add(this.altaCampoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camposGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altaCampoButton;
        private System.Windows.Forms.DataGridView camposGrid;
    }
}


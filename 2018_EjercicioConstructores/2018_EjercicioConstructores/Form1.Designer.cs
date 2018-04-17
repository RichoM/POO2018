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
            this.borrarCampoButton = new System.Windows.Forms.Button();
            this.modificarCampoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camposGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // altaCampoButton
            // 
            this.altaCampoButton.Location = new System.Drawing.Point(12, 12);
            this.altaCampoButton.Name = "altaCampoButton";
            this.altaCampoButton.Size = new System.Drawing.Size(165, 40);
            this.altaCampoButton.TabIndex = 0;
            this.altaCampoButton.Text = "Agregar campo...";
            this.altaCampoButton.UseVisualStyleBackColor = true;
            this.altaCampoButton.Click += new System.EventHandler(this.altaCampoButton_Click);
            // 
            // camposGrid
            // 
            this.camposGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camposGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camposGrid.Location = new System.Drawing.Point(184, 13);
            this.camposGrid.Name = "camposGrid";
            this.camposGrid.Size = new System.Drawing.Size(544, 360);
            this.camposGrid.TabIndex = 1;
            // 
            // borrarCampoButton
            // 
            this.borrarCampoButton.Location = new System.Drawing.Point(12, 58);
            this.borrarCampoButton.Name = "borrarCampoButton";
            this.borrarCampoButton.Size = new System.Drawing.Size(165, 40);
            this.borrarCampoButton.TabIndex = 2;
            this.borrarCampoButton.Text = "Borrar campo";
            this.borrarCampoButton.UseVisualStyleBackColor = true;
            this.borrarCampoButton.Click += new System.EventHandler(this.borrarCampoButton_Click);
            // 
            // modificarCampoButton
            // 
            this.modificarCampoButton.Location = new System.Drawing.Point(12, 104);
            this.modificarCampoButton.Name = "modificarCampoButton";
            this.modificarCampoButton.Size = new System.Drawing.Size(165, 40);
            this.modificarCampoButton.TabIndex = 3;
            this.modificarCampoButton.Text = "Modificar campo...";
            this.modificarCampoButton.UseVisualStyleBackColor = true;
            this.modificarCampoButton.Click += new System.EventHandler(this.modificarCampoButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Presionar a la memoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "GC.Collect()";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modificarCampoButton);
            this.Controls.Add(this.borrarCampoButton);
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
        private System.Windows.Forms.Button borrarCampoButton;
        private System.Windows.Forms.Button modificarCampoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


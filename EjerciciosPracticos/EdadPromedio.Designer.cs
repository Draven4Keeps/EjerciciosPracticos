namespace EjerciciosPracticos
{
    partial class EdadPromedio
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
            this.label1 = new System.Windows.Forms.Label();
            this.edad1 = new System.Windows.Forms.TextBox();
            this.edad2 = new System.Windows.Forms.TextBox();
            this.edad3 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese las edades";
            // 
            // edad1
            // 
            this.edad1.Location = new System.Drawing.Point(31, 41);
            this.edad1.Name = "edad1";
            this.edad1.Size = new System.Drawing.Size(193, 22);
            this.edad1.TabIndex = 1;
            // 
            // edad2
            // 
            this.edad2.Location = new System.Drawing.Point(274, 41);
            this.edad2.Name = "edad2";
            this.edad2.Size = new System.Drawing.Size(184, 22);
            this.edad2.TabIndex = 2;
            // 
            // edad3
            // 
            this.edad3.Location = new System.Drawing.Point(511, 41);
            this.edad3.Name = "edad3";
            this.edad3.Size = new System.Drawing.Size(176, 22);
            this.edad3.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(306, 302);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(130, 54);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // EdadPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.edad3);
            this.Controls.Add(this.edad2);
            this.Controls.Add(this.edad1);
            this.Controls.Add(this.label1);
            this.Name = "EdadPromedio";
            this.Text = "EdadPromedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edad1;
        private System.Windows.Forms.TextBox edad2;
        private System.Windows.Forms.TextBox edad3;
        private System.Windows.Forms.Button calcular;
    }
}
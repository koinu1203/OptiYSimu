namespace ProyectAsimov.Ventanas
{
    partial class details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(details));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alertaY = new System.Windows.Forms.PictureBox();
            this.alertaX = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numeroX = new System.Windows.Forms.NumericUpDown();
            this.numeroY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WebLetterer BB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.alertaY);
            this.panel1.Controls.Add(this.alertaX);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numeroX);
            this.panel1.Controls.Add(this.numeroY);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 189);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // alertaY
            // 
            this.alertaY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alertaY.Image = ((System.Drawing.Image)(resources.GetObject("alertaY.Image")));
            this.alertaY.Location = new System.Drawing.Point(216, 66);
            this.alertaY.Name = "alertaY";
            this.alertaY.Size = new System.Drawing.Size(36, 34);
            this.alertaY.TabIndex = 4;
            this.alertaY.TabStop = false;
            this.alertaY.Visible = false;
            this.alertaY.Click += new System.EventHandler(this.alertaY_Click);
            // 
            // alertaX
            // 
            this.alertaX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alertaX.Image = ((System.Drawing.Image)(resources.GetObject("alertaX.Image")));
            this.alertaX.Location = new System.Drawing.Point(216, 30);
            this.alertaX.Name = "alertaX";
            this.alertaX.Size = new System.Drawing.Size(36, 30);
            this.alertaX.TabIndex = 4;
            this.alertaX.TabStop = false;
            this.alertaX.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("WebLetterer BB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(167, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("WebLetterer BB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lauch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("WebLetterer BB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(13, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(265, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "export solution to excel";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numeroX
            // 
            this.numeroX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroX.Font = new System.Drawing.Font("WebLetterer BB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroX.Location = new System.Drawing.Point(125, 33);
            this.numeroX.Name = "numeroX";
            this.numeroX.Size = new System.Drawing.Size(85, 23);
            this.numeroX.TabIndex = 1;
            this.numeroX.Enter += new System.EventHandler(this.numeroX_Enter);
            this.numeroX.Validating += new System.ComponentModel.CancelEventHandler(this.numeroX_Validating);
            // 
            // numeroY
            // 
            this.numeroY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroY.Font = new System.Drawing.Font("WebLetterer BB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroY.Location = new System.Drawing.Point(125, 68);
            this.numeroY.Name = "numeroY";
            this.numeroY.Size = new System.Drawing.Size(85, 23);
            this.numeroY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("WebLetterer BB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WebLetterer BB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "X:";
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(318, 213);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propertis ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.details_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.details_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeroY;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numeroX;
        private System.Windows.Forms.PictureBox alertaX;
        private System.Windows.Forms.PictureBox alertaY;
    }
}
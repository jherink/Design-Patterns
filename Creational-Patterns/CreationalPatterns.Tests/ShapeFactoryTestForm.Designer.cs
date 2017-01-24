namespace CreationalPatterns.Tests
{
    partial class ShapeFactoryTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenShape = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuadirlateral = new System.Windows.Forms.RadioButton();
            this.btnEllipse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenShape
            // 
            this.btnGenShape.Location = new System.Drawing.Point(156, 47);
            this.btnGenShape.Name = "btnGenShape";
            this.btnGenShape.Size = new System.Drawing.Size(102, 23);
            this.btnGenShape.TabIndex = 3;
            this.btnGenShape.Text = "Generate Shape";
            this.btnGenShape.UseVisualStyleBackColor = true;
            this.btnGenShape.Click += new System.EventHandler(this.btnGenShape_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnQuadirlateral);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnQuadirlateral
            // 
            this.btnQuadirlateral.AutoSize = true;
            this.btnQuadirlateral.Location = new System.Drawing.Point(7, 19);
            this.btnQuadirlateral.Name = "btnQuadirlateral";
            this.btnQuadirlateral.Size = new System.Drawing.Size(84, 17);
            this.btnQuadirlateral.TabIndex = 0;
            this.btnQuadirlateral.TabStop = true;
            this.btnQuadirlateral.Text = "Quadrilateral";
            this.btnQuadirlateral.UseVisualStyleBackColor = true;
            this.btnQuadirlateral.CheckedChanged += new System.EventHandler(this.btnQuadirlateral_CheckedChanged);
            // 
            // btnEllipse
            // 
            this.btnEllipse.AutoSize = true;
            this.btnEllipse.Location = new System.Drawing.Point(7, 42);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(55, 17);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.TabStop = true;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.CheckedChanged += new System.EventHandler(this.btnEllipse_CheckedChanged);
            // 
            // ShapeFactoryTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenShape);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShapeFactoryTestForm";
            this.Text = "ShapeFactoryTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenShape;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnEllipse;
        private System.Windows.Forms.RadioButton btnQuadirlateral;
    }
}
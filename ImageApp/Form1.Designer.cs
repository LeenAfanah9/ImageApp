
namespace ImageApp
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
            this.btnColorImage = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHight = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorImage
            // 
            this.btnColorImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnColorImage.ForeColor = System.Drawing.Color.SeaShell;
            this.btnColorImage.Location = new System.Drawing.Point(1, 1);
            this.btnColorImage.Name = "btnColorImage";
            this.btnColorImage.Size = new System.Drawing.Size(596, 84);
            this.btnColorImage.TabIndex = 0;
            this.btnColorImage.Text = "Color";
            this.btnColorImage.UseVisualStyleBackColor = false;
            this.btnColorImage.Click += new System.EventHandler(this.btnColorImage_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBrowseImage.ForeColor = System.Drawing.Color.SeaShell;
            this.btnBrowseImage.Location = new System.Drawing.Point(541, 1);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(604, 84);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hight";
            this.label3.Visible = false;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(19, 136);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(152, 45);
            this.nudWidth.TabIndex = 5;
            this.nudWidth.Visible = false;
            // 
            // nudHight
            // 
            this.nudHight.Location = new System.Drawing.Point(19, 248);
            this.nudHight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHight.Name = "nudHight";
            this.nudHight.Size = new System.Drawing.Size(152, 45);
            this.nudHight.TabIndex = 6;
            this.nudHight.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnColor.ForeColor = System.Drawing.Color.SeaShell;
            this.btnColor.Location = new System.Drawing.Point(19, 345);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(152, 46);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Choose ...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Visible = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnView.ForeColor = System.Drawing.Color.SeaShell;
            this.btnView.Location = new System.Drawing.Point(19, 478);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(276, 53);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(346, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 502);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1136, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.nudHight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.btnColorImage);
            this.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Image App";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHight;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


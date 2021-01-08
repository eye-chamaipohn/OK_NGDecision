
namespace imageObjDetect
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.fLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confidentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrowse.Location = new System.Drawing.Point(12, 536);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 85);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetect.Location = new System.Drawing.Point(160, 536);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(133, 85);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(832, 505);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fLabel.Location = new System.Drawing.Point(12, 39);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(36, 34);
            this.fLabel.TabIndex = 3;
            this.fLabel.Text = "...";
            this.fLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confidentLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fLabel);
            this.panel1.Location = new System.Drawing.Point(310, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 85);
            this.panel1.TabIndex = 4;
            // 
            // confidentLabel
            // 
            this.confidentLabel.AutoSize = true;
            this.confidentLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.confidentLabel.Location = new System.Drawing.Point(315, 39);
            this.confidentLabel.Name = "confidentLabel";
            this.confidentLabel.Size = new System.Drawing.Size(36, 34);
            this.confidentLabel.TabIndex = 8;
            this.confidentLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confidence:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultLabel.Location = new System.Drawing.Point(158, 38);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(36, 34);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "...";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label confidentLabel;
    }
}


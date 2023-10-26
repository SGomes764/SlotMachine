namespace SlotMachine
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
            this.btnSPIN = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lblNAME = new System.Windows.Forms.Label();
            this.lblSLOT_1 = new System.Windows.Forms.Label();
            this.lblSLOT_2 = new System.Windows.Forms.Label();
            this.lblSLOT_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSPIN
            // 
            this.btnSPIN.BackColor = System.Drawing.Color.Red;
            this.btnSPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPIN.Location = new System.Drawing.Point(12, 65);
            this.btnSPIN.Name = "btnSPIN";
            this.btnSPIN.Size = new System.Drawing.Size(117, 60);
            this.btnSPIN.TabIndex = 0;
            this.btnSPIN.Text = "SPIN";
            this.btnSPIN.UseVisualStyleBackColor = false;
            this.btnSPIN.Click += new System.EventHandler(this.btnSPIN_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Red;
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(12, 144);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(117, 60);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // lblNAME
            // 
            this.lblNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAME.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNAME.Location = new System.Drawing.Point(306, 231);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(266, 42);
            this.lblNAME.TabIndex = 2;
            this.lblNAME.Text = "Lucky Seven";
            this.lblNAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSLOT_1
            // 
            this.lblSLOT_1.BackColor = System.Drawing.Color.Gold;
            this.lblSLOT_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLOT_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLOT_1.Location = new System.Drawing.Point(306, 114);
            this.lblSLOT_1.Name = "lblSLOT_1";
            this.lblSLOT_1.Size = new System.Drawing.Size(54, 57);
            this.lblSLOT_1.TabIndex = 3;
            this.lblSLOT_1.Text = " ";
            this.lblSLOT_1.Click += new System.EventHandler(this.lblSLOT_1_Click);
            // 
            // lblSLOT_2
            // 
            this.lblSLOT_2.BackColor = System.Drawing.Color.Gold;
            this.lblSLOT_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLOT_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLOT_2.Location = new System.Drawing.Point(415, 114);
            this.lblSLOT_2.Name = "lblSLOT_2";
            this.lblSLOT_2.Size = new System.Drawing.Size(54, 57);
            this.lblSLOT_2.TabIndex = 4;
            this.lblSLOT_2.Text = " ";
            this.lblSLOT_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSLOT_3
            // 
            this.lblSLOT_3.BackColor = System.Drawing.Color.Gold;
            this.lblSLOT_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLOT_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLOT_3.Location = new System.Drawing.Point(518, 114);
            this.lblSLOT_3.Name = "lblSLOT_3";
            this.lblSLOT_3.Size = new System.Drawing.Size(54, 57);
            this.lblSLOT_3.TabIndex = 5;
            this.lblSLOT_3.Text = " ";
            this.lblSLOT_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSLOT_3);
            this.Controls.Add(this.lblSLOT_2);
            this.Controls.Add(this.lblSLOT_1);
            this.Controls.Add(this.lblNAME);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnSPIN);
            this.Name = "Form1";
            this.Text = "Lucky Seven";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPIN;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.Label lblSLOT_1;
        private System.Windows.Forms.Label lblSLOT_2;
        private System.Windows.Forms.Label lblSLOT_3;
    }
}


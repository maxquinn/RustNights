namespace RustNights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DayTimeButton = new System.Windows.Forms.Button();
            this.NightTimeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayTimeButton
            // 
            this.DayTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayTimeButton.BackColor = System.Drawing.Color.Gold;
            this.DayTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayTimeButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTimeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DayTimeButton.Location = new System.Drawing.Point(82, 83);
            this.DayTimeButton.Name = "DayTimeButton";
            this.DayTimeButton.Size = new System.Drawing.Size(134, 63);
            this.DayTimeButton.TabIndex = 0;
            this.DayTimeButton.Text = "Day";
            this.DayTimeButton.UseVisualStyleBackColor = false;
            this.DayTimeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NightTimeButton
            // 
            this.NightTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NightTimeButton.BackColor = System.Drawing.Color.Navy;
            this.NightTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NightTimeButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NightTimeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NightTimeButton.Location = new System.Drawing.Point(82, 83);
            this.NightTimeButton.Name = "NightTimeButton";
            this.NightTimeButton.Size = new System.Drawing.Size(134, 63);
            this.NightTimeButton.TabIndex = 1;
            this.NightTimeButton.Text = "Night";
            this.NightTimeButton.UseVisualStyleBackColor = false;
            this.NightTimeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by DMT©";
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(12, 229);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(89, 23);
            this.DefaultButton.TabIndex = 3;
            this.DefaultButton.Text = "Default Gamma";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NightTimeButton);
            this.Controls.Add(this.DayTimeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rust Nights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DayTimeButton;
        private System.Windows.Forms.Button NightTimeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DefaultButton;
    }
}


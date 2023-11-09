
namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.generatePassBT = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.CharNum_la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spec_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generatePassBT
            // 
            this.generatePassBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generatePassBT.Location = new System.Drawing.Point(40, 153);
            this.generatePassBT.Margin = new System.Windows.Forms.Padding(65, 30, 3, 3);
            this.generatePassBT.Name = "generatePassBT";
            this.generatePassBT.Size = new System.Drawing.Size(171, 49);
            this.generatePassBT.TabIndex = 0;
            this.generatePassBT.Text = "Generate password";
            this.generatePassBT.UseVisualStyleBackColor = true;
            this.generatePassBT.Click += new System.EventHandler(this.generatePassBT_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTB.Location = new System.Drawing.Point(40, 112);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(65, 70, 3, 3);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(170, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // num_tb
            // 
            this.num_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_tb.Location = new System.Drawing.Point(40, 34);
            this.num_tb.Margin = new System.Windows.Forms.Padding(65, 70, 3, 3);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(170, 20);
            this.num_tb.TabIndex = 2;
            this.num_tb.Text = "12";
            // 
            // CharNum_la
            // 
            this.CharNum_la.AutoSize = true;
            this.CharNum_la.Location = new System.Drawing.Point(37, 19);
            this.CharNum_la.Name = "CharNum_la";
            this.CharNum_la.Size = new System.Drawing.Size(112, 13);
            this.CharNum_la.TabIndex = 3;
            this.CharNum_la.Text = "Number of characters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of specials:";
            // 
            // spec_tb
            // 
            this.spec_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spec_tb.Location = new System.Drawing.Point(40, 73);
            this.spec_tb.Margin = new System.Windows.Forms.Padding(65, 70, 3, 3);
            this.spec_tb.Name = "spec_tb";
            this.spec_tb.Size = new System.Drawing.Size(170, 20);
            this.spec_tb.TabIndex = 5;
            this.spec_tb.Text = "1";
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(252, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spec_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharNum_la);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.generatePassBT);
            this.Controls.Add(this.passwordTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generatePassBT;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Label CharNum_la;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spec_tb;
    }
}


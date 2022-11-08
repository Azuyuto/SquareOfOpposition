namespace SquareOfOpposition
{
    partial class SquareForm
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
            this.SoPTxt = new System.Windows.Forms.TextBox();
            this.SePTxt = new System.Windows.Forms.TextBox();
            this.SaPTxt = new System.Windows.Forms.TextBox();
            this.SiPTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoPTxt
            // 
            this.SoPTxt.Location = new System.Drawing.Point(568, 397);
            this.SoPTxt.Name = "SoPTxt";
            this.SoPTxt.Size = new System.Drawing.Size(150, 27);
            this.SoPTxt.TabIndex = 0;
            this.SoPTxt.TextChanged += new System.EventHandler(this.SoPTxt_TextChanged);
            // 
            // SePTxt
            // 
            this.SePTxt.Location = new System.Drawing.Point(568, 115);
            this.SePTxt.Name = "SePTxt";
            this.SePTxt.Size = new System.Drawing.Size(150, 27);
            this.SePTxt.TabIndex = 1;
            this.SePTxt.TextChanged += new System.EventHandler(this.SePTxt_TextChanged);
            // 
            // SaPTxt
            // 
            this.SaPTxt.Location = new System.Drawing.Point(184, 115);
            this.SaPTxt.Name = "SaPTxt";
            this.SaPTxt.Size = new System.Drawing.Size(150, 27);
            this.SaPTxt.TabIndex = 2;
            this.SaPTxt.TextChanged += new System.EventHandler(this.SaPTxt_TextChanged);
            // 
            // SiPTxt
            // 
            this.SiPTxt.Location = new System.Drawing.Point(184, 397);
            this.SiPTxt.Name = "SiPTxt";
            this.SiPTxt.Size = new System.Drawing.Size(150, 27);
            this.SiPTxt.TabIndex = 3;
            this.SiPTxt.TextChanged += new System.EventHandler(this.SiPTxt_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(737, 493);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 37);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(92, 493);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 37);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Anuluj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 590);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SiPTxt);
            this.Controls.Add(this.SaPTxt);
            this.Controls.Add(this.SePTxt);
            this.Controls.Add(this.SoPTxt);
            this.Name = "SquareForm";
            this.Text = "SquareForm";
            this.Load += new System.EventHandler(this.SquareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SoPTxt;
        private TextBox SePTxt;
        private TextBox SaPTxt;
        private TextBox SiPTxt;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}
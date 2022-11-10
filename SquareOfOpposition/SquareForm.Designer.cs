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
            this.labelA = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SoPTxt
            // 
            this.SoPTxt.Location = new System.Drawing.Point(520, 310);
            this.SoPTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SoPTxt.Name = "SoPTxt";
            this.SoPTxt.Size = new System.Drawing.Size(132, 23);
            this.SoPTxt.TabIndex = 0;
            this.SoPTxt.TextChanged += new System.EventHandler(this.SoPTxt_TextChanged);
            // 
            // SePTxt
            // 
            this.SePTxt.Location = new System.Drawing.Point(520, 86);
            this.SePTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SePTxt.Name = "SePTxt";
            this.SePTxt.Size = new System.Drawing.Size(132, 23);
            this.SePTxt.TabIndex = 1;
            this.SePTxt.TextChanged += new System.EventHandler(this.SePTxt_TextChanged);
            // 
            // SaPTxt
            // 
            this.SaPTxt.Location = new System.Drawing.Point(161, 86);
            this.SaPTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaPTxt.Name = "SaPTxt";
            this.SaPTxt.Size = new System.Drawing.Size(132, 23);
            this.SaPTxt.TabIndex = 2;
            this.SaPTxt.TextChanged += new System.EventHandler(this.SaPTxt_TextChanged);
            // 
            // SiPTxt
            // 
            this.SiPTxt.Location = new System.Drawing.Point(161, 310);
            this.SiPTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SiPTxt.Name = "SiPTxt";
            this.SiPTxt.Size = new System.Drawing.Size(132, 23);
            this.SiPTxt.TabIndex = 3;
            this.SiPTxt.TextChanged += new System.EventHandler(this.SiPTxt_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(634, 377);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(102, 28);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(81, 377);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(102, 28);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Anuluj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(217, 69);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(15, 15);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "A";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(584, 69);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(13, 15);
            this.labelE.TabIndex = 7;
            this.labelE.Text = "E";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(219, 335);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(10, 15);
            this.labelI.TabIndex = 8;
            this.labelI.Text = "I";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(587, 335);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(16, 15);
            this.labelO.TabIndex = 9;
            this.labelO.Text = "O";
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 426);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SiPTxt);
            this.Controls.Add(this.SaPTxt);
            this.Controls.Add(this.SePTxt);
            this.Controls.Add(this.SoPTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Label labelA;
        private Label labelE;
        private Label labelI;
        private Label labelO;
    }
}
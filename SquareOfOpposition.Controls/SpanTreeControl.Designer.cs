namespace SquareOfOpposition.Controls
{
    partial class SpanTreeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_AI = new SquareOfOpposition.Controls.RoundButton();
            this.button_EO = new SquareOfOpposition.Controls.RoundButton();
            this.button_IO = new SquareOfOpposition.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // button_AI
            // 
            this.button_AI.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_AI.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_AI.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_AI.BorderRadius = 20;
            this.button_AI.BorderSize = 0;
            this.button_AI.FlatAppearance.BorderSize = 0;
            this.button_AI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AI.ForeColor = System.Drawing.Color.White;
            this.button_AI.Location = new System.Drawing.Point(3, 147);
            this.button_AI.Name = "button_AI";
            this.button_AI.Size = new System.Drawing.Size(50, 50);
            this.button_AI.TabIndex = 0;
            this.button_AI.Text = "AI";
            this.button_AI.TextColor = System.Drawing.Color.White;
            this.button_AI.UseVisualStyleBackColor = false;
            // 
            // button_EO
            // 
            this.button_EO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_EO.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_EO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_EO.BorderRadius = 20;
            this.button_EO.BorderSize = 0;
            this.button_EO.FlatAppearance.BorderSize = 0;
            this.button_EO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EO.ForeColor = System.Drawing.Color.White;
            this.button_EO.Location = new System.Drawing.Point(179, 147);
            this.button_EO.Name = "button_EO";
            this.button_EO.Size = new System.Drawing.Size(50, 50);
            this.button_EO.TabIndex = 1;
            this.button_EO.Text = "EO";
            this.button_EO.TextColor = System.Drawing.Color.White;
            this.button_EO.UseVisualStyleBackColor = false;
            // 
            // button_IO
            // 
            this.button_IO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_IO.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button_IO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_IO.BorderRadius = 20;
            this.button_IO.BorderSize = 0;
            this.button_IO.FlatAppearance.BorderSize = 0;
            this.button_IO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_IO.ForeColor = System.Drawing.Color.White;
            this.button_IO.Location = new System.Drawing.Point(347, 147);
            this.button_IO.Name = "button_IO";
            this.button_IO.Size = new System.Drawing.Size(50, 50);
            this.button_IO.TabIndex = 2;
            this.button_IO.Text = "IO";
            this.button_IO.TextColor = System.Drawing.Color.White;
            this.button_IO.UseVisualStyleBackColor = false;
            // 
            // SpanTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_IO);
            this.Controls.Add(this.button_EO);
            this.Controls.Add(this.button_AI);
            this.Name = "SpanTreeControl";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton button_AI;
        private RoundButton button_EO;
        private RoundButton button_IO;
    }
}

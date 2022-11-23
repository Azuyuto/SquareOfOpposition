namespace SquareOfOpposition.Controls
{
    partial class StateMachineControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AIButton = new SquareOfOpposition.Controls.RoundButton();
            this.IOButton = new SquareOfOpposition.Controls.RoundButton();
            this.EOButton = new SquareOfOpposition.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // AIButton
            // 
            this.AIButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AIButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AIButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AIButton.BorderRadius = 20;
            this.AIButton.BorderSize = 0;
            this.AIButton.FlatAppearance.BorderSize = 0;
            this.AIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AIButton.ForeColor = System.Drawing.Color.White;
            this.AIButton.Location = new System.Drawing.Point(143, 88);
            this.AIButton.Name = "AIButton";
            this.AIButton.Size = new System.Drawing.Size(62, 63);
            this.AIButton.TabIndex = 0;
            this.AIButton.Text = "A I";
            this.AIButton.TextColor = System.Drawing.Color.White;
            this.AIButton.UseVisualStyleBackColor = false;
            this.AIButton.Click += new System.EventHandler(this.AIButton_Click);
            // 
            // IOButton
            // 
            this.IOButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.IOButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.IOButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.IOButton.BorderRadius = 20;
            this.IOButton.BorderSize = 0;
            this.IOButton.FlatAppearance.BorderSize = 0;
            this.IOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IOButton.ForeColor = System.Drawing.Color.White;
            this.IOButton.Location = new System.Drawing.Point(263, 268);
            this.IOButton.Name = "IOButton";
            this.IOButton.Size = new System.Drawing.Size(62, 63);
            this.IOButton.TabIndex = 1;
            this.IOButton.Text = "I O";
            this.IOButton.TextColor = System.Drawing.Color.White;
            this.IOButton.UseVisualStyleBackColor = false;
            this.IOButton.Click += new System.EventHandler(this.IOButton_Click);
            // 
            // EOButton
            // 
            this.EOButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EOButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.EOButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EOButton.BorderRadius = 20;
            this.EOButton.BorderSize = 0;
            this.EOButton.FlatAppearance.BorderSize = 0;
            this.EOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EOButton.ForeColor = System.Drawing.Color.White;
            this.EOButton.Location = new System.Drawing.Point(392, 88);
            this.EOButton.Name = "EOButton";
            this.EOButton.Size = new System.Drawing.Size(62, 63);
            this.EOButton.TabIndex = 2;
            this.EOButton.Text = "E O";
            this.EOButton.TextColor = System.Drawing.Color.White;
            this.EOButton.UseVisualStyleBackColor = false;
            this.EOButton.Click += new System.EventHandler(this.EOButton_Click);
            // 
            // StateMachineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EOButton);
            this.Controls.Add(this.IOButton);
            this.Controls.Add(this.AIButton);
            this.Name = "StateMachineControl";
            this.Size = new System.Drawing.Size(584, 443);
            this.Load += new System.EventHandler(this.StateMachineControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton AIButton;
        private RoundButton IOButton;
        private RoundButton EOButton;
    }
}

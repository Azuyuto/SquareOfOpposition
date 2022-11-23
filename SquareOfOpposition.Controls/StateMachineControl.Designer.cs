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
            this.arrowAIEO = new System.Windows.Forms.PictureBox();
            this.arrowEOAI = new System.Windows.Forms.PictureBox();
            this.arrowEOIO = new System.Windows.Forms.PictureBox();
            this.arrowIOEO = new System.Windows.Forms.PictureBox();
            this.arrowIOAI = new System.Windows.Forms.PictureBox();
            this.arrowAIIO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowAIEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowEOAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowEOIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowIOEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowIOAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowAIIO)).BeginInit();
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
            this.AIButton.Location = new System.Drawing.Point(14, 19);
            this.AIButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AIButton.Name = "AIButton";
            this.AIButton.Size = new System.Drawing.Size(54, 47);
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
            this.IOButton.Location = new System.Drawing.Point(172, 176);
            this.IOButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IOButton.Name = "IOButton";
            this.IOButton.Size = new System.Drawing.Size(54, 47);
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
            this.EOButton.Location = new System.Drawing.Point(332, 19);
            this.EOButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EOButton.Name = "EOButton";
            this.EOButton.Size = new System.Drawing.Size(54, 47);
            this.EOButton.TabIndex = 2;
            this.EOButton.Text = "E O";
            this.EOButton.TextColor = System.Drawing.Color.White;
            this.EOButton.UseVisualStyleBackColor = false;
            this.EOButton.Click += new System.EventHandler(this.EOButton_Click);
            // 
            // arrowAIEO
            // 
            this.arrowAIEO.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow;
            this.arrowAIEO.Location = new System.Drawing.Point(74, 9);
            this.arrowAIEO.Name = "arrowAIEO";
            this.arrowAIEO.Size = new System.Drawing.Size(252, 45);
            this.arrowAIEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowAIEO.TabIndex = 3;
            this.arrowAIEO.TabStop = false;
            // 
            // arrowEOAI
            // 
            this.arrowEOAI.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow;
            this.arrowEOAI.Location = new System.Drawing.Point(74, 35);
            this.arrowEOAI.Name = "arrowEOAI";
            this.arrowEOAI.Size = new System.Drawing.Size(252, 41);
            this.arrowEOAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowEOAI.TabIndex = 4;
            this.arrowEOAI.TabStop = false;
            // 
            // arrowEOIO
            // 
            this.arrowEOIO.BackColor = System.Drawing.Color.Transparent;
            this.arrowEOIO.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow45;
            this.arrowEOIO.Location = new System.Drawing.Point(233, 71);
            this.arrowEOIO.Name = "arrowEOIO";
            this.arrowEOIO.Size = new System.Drawing.Size(118, 111);
            this.arrowEOIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowEOIO.TabIndex = 7;
            this.arrowEOIO.TabStop = false;
            // 
            // arrowIOEO
            // 
            this.arrowIOEO.BackColor = System.Drawing.Color.Transparent;
            this.arrowIOEO.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow45;
            this.arrowIOEO.Location = new System.Drawing.Point(218, 60);
            this.arrowIOEO.Name = "arrowIOEO";
            this.arrowIOEO.Size = new System.Drawing.Size(118, 111);
            this.arrowIOEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowIOEO.TabIndex = 8;
            this.arrowIOEO.TabStop = false;
            // 
            // arrowIOAI
            // 
            this.arrowIOAI.BackColor = System.Drawing.Color.Transparent;
            this.arrowIOAI.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow45;
            this.arrowIOAI.Location = new System.Drawing.Point(44, 71);
            this.arrowIOAI.Name = "arrowIOAI";
            this.arrowIOAI.Size = new System.Drawing.Size(118, 111);
            this.arrowIOAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowIOAI.TabIndex = 9;
            this.arrowIOAI.TabStop = false;
            // 
            // arrowAIIO
            // 
            this.arrowAIIO.BackColor = System.Drawing.Color.Transparent;
            this.arrowAIIO.Image = global::SquareOfOpposition.Controls.Properties.Resources.arrow45;
            this.arrowAIIO.Location = new System.Drawing.Point(64, 60);
            this.arrowAIIO.Name = "arrowAIIO";
            this.arrowAIIO.Size = new System.Drawing.Size(118, 111);
            this.arrowAIIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowAIIO.TabIndex = 10;
            this.arrowAIIO.TabStop = false;
            // 
            // StateMachineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.arrowAIIO);
            this.Controls.Add(this.arrowIOAI);
            this.Controls.Add(this.arrowIOEO);
            this.Controls.Add(this.arrowEOIO);
            this.Controls.Add(this.arrowEOAI);
            this.Controls.Add(this.arrowAIEO);
            this.Controls.Add(this.EOButton);
            this.Controls.Add(this.IOButton);
            this.Controls.Add(this.AIButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StateMachineControl";
            this.Size = new System.Drawing.Size(400, 235);
            this.Load += new System.EventHandler(this.StateMachineControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.arrowAIEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowEOAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowEOIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowIOEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowIOAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowAIIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton AIButton;
        private RoundButton IOButton;
        private RoundButton EOButton;
        private PictureBox arrowAIEO;
        private PictureBox arrowEOAI;
        private PictureBox arrowEOIO;
        private PictureBox arrowIOEO;
        private PictureBox arrowIOAI;
        private PictureBox arrowAIIO;
    }
}

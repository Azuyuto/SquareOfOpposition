namespace SquareOfOpposition.Controls
{
    partial class RootNode
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
            this.inLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inLabel
            // 
            this.inLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.inLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.inLabel.Location = new System.Drawing.Point(0, 0);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(150, 35);
            this.inLabel.TabIndex = 0;
            this.inLabel.Text = "IN";
            this.inLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RootNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.inLabel);
            this.Name = "RootNode";
            this.Size = new System.Drawing.Size(150, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private Label inLabel;
    }
}

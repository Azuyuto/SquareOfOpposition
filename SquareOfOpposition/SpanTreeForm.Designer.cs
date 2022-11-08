namespace SquareOfOpposition
{
    partial class SpanTreeForm
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
            this.spanTreeControl1 = new SquareOfOpposition.Controls.SpanTreeControl();
            this.SuspendLayout();
            // 
            // spanTreeControl1
            // 
            this.spanTreeControl1.Location = new System.Drawing.Point(147, 65);
            this.spanTreeControl1.Name = "spanTreeControl1";
            this.spanTreeControl1.Size = new System.Drawing.Size(480, 270);
            this.spanTreeControl1.TabIndex = 0;
            // 
            // SpanTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spanTreeControl1);
            this.Name = "SpanTreeForm";
            this.Text = "SpanTreeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SpanTreeControl spanTreeControl1;
    }
}
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
            this.spanTreeControl1.Location = new System.Drawing.Point(168, 87);
            this.spanTreeControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.spanTreeControl1.Name = "spanTreeControl1";
            this.spanTreeControl1.Size = new System.Drawing.Size(549, 360);
            this.spanTreeControl1.TabIndex = 0;
            this.spanTreeControl1.Load += new System.EventHandler(this.spanTreeControl1_Load);
            // 
            // SpanTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.spanTreeControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SpanTreeForm";
            this.Text = "SpanTreeForm";
            this.ResumeLayout(false);

        }

        #endregion

#pragma warning disable CS0246 // Nie można znaleźć nazwy typu lub przestrzeni nazw „Controls” (brak dyrektywy using lub odwołania do zestawu?)
        private Controls.SpanTreeControl spanTreeControl1;
#pragma warning restore CS0246 // Nie można znaleźć nazwy typu lub przestrzeni nazw „Controls” (brak dyrektywy using lub odwołania do zestawu?)
    }
}
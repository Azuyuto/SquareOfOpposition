namespace SquareOfOpposition
{
    partial class MachineStateForm
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
            this.panelRender = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRender
            // 
            this.panelRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRender.Location = new System.Drawing.Point(0, 0);
            this.panelRender.Name = "panelRender";
            this.panelRender.Size = new System.Drawing.Size(684, 361);
            this.panelRender.TabIndex = 1;
            // 
            // MachineStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panelRender);
            this.Name = "MachineStateForm";
            this.Text = "MachineStateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelRender;
    }
}
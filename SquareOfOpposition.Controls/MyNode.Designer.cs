namespace SquareOfOpposition.Controls
{
    partial class MyNode
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sentenceUpPanel = new System.Windows.Forms.Panel();
            this.sentenceUpLabel = new System.Windows.Forms.Label();
            this.sentenceDownPanel = new System.Windows.Forms.Panel();
            this.sentenceDownLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.sentenceUpPanel.SuspendLayout();
            this.sentenceDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.sentenceUpPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.sentenceDownPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // sentenceUpPanel
            // 
            this.sentenceUpPanel.Controls.Add(this.sentenceUpLabel);
            this.sentenceUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentenceUpPanel.Location = new System.Drawing.Point(3, 3);
            this.sentenceUpPanel.Name = "sentenceUpPanel";
            this.sentenceUpPanel.Size = new System.Drawing.Size(194, 17);
            this.sentenceUpPanel.TabIndex = 0;
            // 
            // sentenceUpLabel
            // 
            this.sentenceUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sentenceUpLabel.Location = new System.Drawing.Point(-25, -7);
            this.sentenceUpLabel.Name = "sentenceUpLabel";
            this.sentenceUpLabel.Size = new System.Drawing.Size(244, 31);
            this.sentenceUpLabel.TabIndex = 0;
            this.sentenceUpLabel.Text = "label1";
            this.sentenceUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sentenceDownPanel
            // 
            this.sentenceDownPanel.Controls.Add(this.sentenceDownLabel);
            this.sentenceDownPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentenceDownPanel.Location = new System.Drawing.Point(3, 26);
            this.sentenceDownPanel.Name = "sentenceDownPanel";
            this.sentenceDownPanel.Size = new System.Drawing.Size(194, 17);
            this.sentenceDownPanel.TabIndex = 1;
            // 
            // sentenceDownLabel
            // 
            this.sentenceDownLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sentenceDownLabel.Location = new System.Drawing.Point(-25, -7);
            this.sentenceDownLabel.Name = "sentenceDownLabel";
            this.sentenceDownLabel.Size = new System.Drawing.Size(244, 31);
            this.sentenceDownLabel.TabIndex = 1;
            this.sentenceDownLabel.Text = "label2";
            this.sentenceDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MyNode";
            this.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel.ResumeLayout(false);
            this.sentenceUpPanel.ResumeLayout(false);
            this.sentenceDownPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel sentenceUpPanel;
        private Label sentenceUpLabel;
        private Panel sentenceDownPanel;
        private Label sentenceDownLabel;
    }
}

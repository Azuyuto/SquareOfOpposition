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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.addSquare = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.menuPanel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(954, 421);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuPanel.Controls.Add(this.addSquare);
            this.menuPanel.Controls.Add(this.openButton);
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 421);
            this.menuPanel.TabIndex = 0;
            // 
            // addSquare
            // 
            this.addSquare.Location = new System.Drawing.Point(3, 66);
            this.addSquare.Name = "addSquare";
            this.addSquare.Size = new System.Drawing.Size(188, 23);
            this.addSquare.TabIndex = 0;
            this.addSquare.Text = "Add square";
            this.addSquare.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(3, 8);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(188, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 37);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // SpanTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 421);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SpanTreeForm";
            this.Text = "SpanTreeForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TableLayoutPanel tableLayoutPanel;
        private Panel menuPanel;
        private Button saveButton;
        private Button openButton;
        private Button addSquare;

        #endregion

#pragma warning disable CS0246 // Nie można znaleźć nazwy typu lub przestrzeni nazw „Controls” (brak dyrektywy using lub odwołania do zestawu?)
#pragma warning restore CS0246 // Nie można znaleźć nazwy typu lub przestrzeni nazw „Controls” (brak dyrektywy using lub odwołania do zestawu?)
    }
}
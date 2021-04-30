namespace MoveWindow {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.moveAllBtn = new System.Windows.Forms.Button();
            this.locLbl = new System.Windows.Forms.Label();
            this.posResult = new System.Windows.Forms.Label();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.currentWindowLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.windowListBox = new System.Windows.Forms.ListBox();
            this.clearSelectionBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveAllBtn
            // 
            this.moveAllBtn.AutoSize = true;
            this.moveAllBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moveAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainTableLayout.SetColumnSpan(this.moveAllBtn, 3);
            this.moveAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveAllBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.moveAllBtn.Location = new System.Drawing.Point(3, 258);
            this.moveAllBtn.MaximumSize = new System.Drawing.Size(0, 150);
            this.moveAllBtn.MinimumSize = new System.Drawing.Size(0, 150);
            this.moveAllBtn.Name = "moveAllBtn";
            this.moveAllBtn.Size = new System.Drawing.Size(478, 150);
            this.moveAllBtn.TabIndex = 0;
            this.moveAllBtn.Text = "Bring Me My Windows!";
            this.moveAllBtn.UseVisualStyleBackColor = false;
            // 
            // locLbl
            // 
            this.locLbl.AutoSize = true;
            this.locLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.locLbl.Location = new System.Drawing.Point(5, 5);
            this.locLbl.Margin = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.locLbl.Name = "locLbl";
            this.locLbl.Size = new System.Drawing.Size(91, 21);
            this.locLbl.TabIndex = 1;
            this.locLbl.Text = "Current Location:";
            this.locLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // posResult
            // 
            this.posResult.AutoSize = true;
            this.posResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.posResult.Location = new System.Drawing.Point(98, 5);
            this.posResult.Margin = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.posResult.Name = "posResult";
            this.posResult.Size = new System.Drawing.Size(285, 21);
            this.posResult.TabIndex = 2;
            this.posResult.Text = "x=0, y=0";
            this.posResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.AutoSize = true;
            this.mainTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayout.ColumnCount = 3;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.Controls.Add(this.locLbl, 0, 0);
            this.mainTableLayout.Controls.Add(this.posResult, 1, 0);
            this.mainTableLayout.Controls.Add(this.resetBtn, 2, 0);
            this.mainTableLayout.Controls.Add(this.currentWindowLbl, 0, 1);
            this.mainTableLayout.Controls.Add(this.windowListBox, 1, 1);
            this.mainTableLayout.Controls.Add(this.clearSelectionBtn, 2, 2);
            this.mainTableLayout.Controls.Add(this.moveAllBtn, 0, 3);
            this.mainTableLayout.Controls.Add(this.refreshBtn, 1, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.MinimumSize = new System.Drawing.Size(260, 210);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 4;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(484, 411);
            this.mainTableLayout.TabIndex = 3;
            // 
            // currentWindowLbl
            // 
            this.currentWindowLbl.AutoSize = true;
            this.currentWindowLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentWindowLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.currentWindowLbl.Location = new System.Drawing.Point(5, 36);
            this.currentWindowLbl.Margin = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.currentWindowLbl.Name = "currentWindowLbl";
            this.currentWindowLbl.Size = new System.Drawing.Size(91, 183);
            this.currentWindowLbl.TabIndex = 5;
            this.currentWindowLbl.Text = "Current Windows:";
            this.currentWindowLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resetBtn.Location = new System.Drawing.Point(391, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(90, 25);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset 0,0";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // windowListBox
            // 
            this.windowListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.windowListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTableLayout.SetColumnSpan(this.windowListBox, 2);
            this.windowListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowListBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.windowListBox.FormattingEnabled = true;
            this.windowListBox.Location = new System.Drawing.Point(102, 36);
            this.windowListBox.Margin = new System.Windows.Forms.Padding(5);
            this.windowListBox.Name = "windowListBox";
            this.windowListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.windowListBox.Size = new System.Drawing.Size(377, 183);
            this.windowListBox.TabIndex = 4;
            // 
            // clearSelectionBtn
            // 
            this.clearSelectionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearSelectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearSelectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectionBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearSelectionBtn.Location = new System.Drawing.Point(391, 227);
            this.clearSelectionBtn.Name = "clearSelectionBtn";
            this.clearSelectionBtn.Size = new System.Drawing.Size(90, 25);
            this.clearSelectionBtn.TabIndex = 6;
            this.clearSelectionBtn.Text = "Clear Selection";
            this.clearSelectionBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.refreshBtn.Location = new System.Drawing.Point(329, 227);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(56, 25);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Window Utility";
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveAllBtn;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Label posResult;
        private System.Windows.Forms.Label locLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label currentWindowLbl;
        private System.Windows.Forms.ListBox windowListBox;
        private System.Windows.Forms.Button clearSelectionBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}


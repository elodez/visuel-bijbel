namespace VisuelBijbel
{
    partial class FormEditor
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gboxVerses = new System.Windows.Forms.GroupBox();
            this.listVerses = new System.Windows.Forms.ListBox();
            this.gboxPreview = new System.Windows.Forms.GroupBox();
            this.layoutPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gboxVerses.SuspendLayout();
            this.gboxPreview.SuspendLayout();
            this.layoutPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(770, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // SessionToolStripMenuItem
            // 
            this.SessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem});
            this.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem";
            this.SessionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.SessionToolStripMenuItem.Text = "SESSION";
            this.SessionToolStripMenuItem.Click += new System.EventHandler(this.sESSIONToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 463);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(770, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gboxVerses);
            this.flowLayoutPanel1.Controls.Add(this.gboxPreview);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 439);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gboxVerses
            // 
            this.gboxVerses.Controls.Add(this.listVerses);
            this.gboxVerses.Location = new System.Drawing.Point(3, 3);
            this.gboxVerses.Name = "gboxVerses";
            this.gboxVerses.Size = new System.Drawing.Size(233, 433);
            this.gboxVerses.TabIndex = 0;
            this.gboxVerses.TabStop = false;
            this.gboxVerses.Text = "Verses";
            this.gboxVerses.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listVerses
            // 
            this.listVerses.FormattingEnabled = true;
            this.listVerses.Location = new System.Drawing.Point(9, 19);
            this.listVerses.Name = "listVerses";
            this.listVerses.Size = new System.Drawing.Size(218, 381);
            this.listVerses.TabIndex = 0;
            // 
            // gboxPreview
            // 
            this.gboxPreview.Controls.Add(this.layoutPreview);
            this.gboxPreview.Location = new System.Drawing.Point(242, 3);
            this.gboxPreview.Name = "gboxPreview";
            this.gboxPreview.Size = new System.Drawing.Size(516, 433);
            this.gboxPreview.TabIndex = 1;
            this.gboxPreview.TabStop = false;
            this.gboxPreview.Text = "Preview";
            // 
            // layoutPreview
            // 
            this.layoutPreview.Controls.Add(this.label1);
            this.layoutPreview.Location = new System.Drawing.Point(6, 19);
            this.layoutPreview.Name = "layoutPreview";
            this.layoutPreview.Size = new System.Drawing.Size(402, 293);
            this.layoutPreview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gboxVerses.ResumeLayout(false);
            this.gboxPreview.ResumeLayout(false);
            this.layoutPreview.ResumeLayout(false);
            this.layoutPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gboxVerses;
        private System.Windows.Forms.ListBox listVerses;
        private System.Windows.Forms.GroupBox gboxPreview;
        private System.Windows.Forms.FlowLayoutPanel layoutPreview;
        private System.Windows.Forms.Label label1;
    }
}


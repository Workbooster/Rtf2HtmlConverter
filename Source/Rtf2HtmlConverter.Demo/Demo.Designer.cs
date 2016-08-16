namespace Rtf2HtmlConverter.Demo
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClearTextFields = new System.Windows.Forms.ToolStripButton();
            this.btnConvert = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRFTPlain = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtHTMLPlain = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearTextFields,
            this.btnConvert});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClearTextFields
            // 
            this.btnClearTextFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearTextFields.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTextFields.Image")));
            this.btnClearTextFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearTextFields.Name = "btnClearTextFields";
            this.btnClearTextFields.Size = new System.Drawing.Size(60, 22);
            this.btnClearTextFields.Text = "Clear RTF";
            this.btnClearTextFields.Click += new System.EventHandler(this.btnClearTextFields_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConvert.Image = ((System.Drawing.Image)(resources.GetObject("btnConvert.Image")));
            this.btnConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 22);
            this.btnConvert.Text = "Run Conversion";
            this.btnConvert.ToolTipText = "Run Conversion";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 536);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRFTPlain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RTF Plan Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRFTPlain
            // 
            this.txtRFTPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRFTPlain.Location = new System.Drawing.Point(3, 3);
            this.txtRFTPlain.Multiline = true;
            this.txtRFTPlain.Name = "txtRFTPlain";
            this.txtRFTPlain.Size = new System.Drawing.Size(770, 229);
            this.txtRFTPlain.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RTF Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 271);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtHTMLPlain);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 245);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "HTML Plain Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtHTMLPlain
            // 
            this.txtHTMLPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHTMLPlain.Location = new System.Drawing.Point(3, 3);
            this.txtHTMLPlain.Multiline = true;
            this.txtHTMLPlain.Name = "txtHTMLPlain";
            this.txtHTMLPlain.Size = new System.Drawing.Size(770, 239);
            this.txtHTMLPlain.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 245);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "HTML Preview";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Demo";
            this.Text = "Rtf2HtmlConverter Demo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConvert;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRFTPlain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtHTMLPlain;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripButton btnClearTextFields;
    }
}


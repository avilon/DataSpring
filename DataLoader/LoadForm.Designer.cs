namespace DataLoader
{
    partial class LoadForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChoice = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bbClose = new System.Windows.Forms.Button();
            this.bbStop = new System.Windows.Forms.Button();
            this.bbStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.bbStart);
            this.panel1.Controls.Add(this.bbStop);
            this.panel1.Controls.Add(this.bbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 52);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChoice);
            this.panel2.Controls.Add(this.tbPath);
            this.panel2.Controls.Add(this.lbPath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 73);
            this.panel2.TabIndex = 4;
            // 
            // btnChoice
            // 
            this.btnChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice.Location = new System.Drawing.Point(292, 32);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(28, 23);
            this.btnChoice.TabIndex = 5;
            this.btnChoice.Text = "...";
            this.btnChoice.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(15, 34);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(271, 20);
            this.tbPath.TabIndex = 4;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(15, 18);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(148, 13);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "Папка размещения файлов";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 137);
            this.panel3.TabIndex = 5;
            // 
            // bbClose
            // 
            this.bbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbClose.Location = new System.Drawing.Point(245, 17);
            this.bbClose.Name = "bbClose";
            this.bbClose.Size = new System.Drawing.Size(75, 25);
            this.bbClose.TabIndex = 0;
            this.bbClose.Text = "Close";
            this.bbClose.UseVisualStyleBackColor = true;
            // 
            // bbStop
            // 
            this.bbStop.Location = new System.Drawing.Point(93, 17);
            this.bbStop.Name = "bbStop";
            this.bbStop.Size = new System.Drawing.Size(75, 25);
            this.bbStop.TabIndex = 1;
            this.bbStop.Text = "Stop";
            this.bbStop.UseVisualStyleBackColor = true;
            // 
            // bbStart
            // 
            this.bbStart.Location = new System.Drawing.Point(12, 17);
            this.bbStart.Name = "bbStart";
            this.bbStart.Size = new System.Drawing.Size(75, 25);
            this.bbStart.TabIndex = 2;
            this.bbStart.Text = "Start";
            this.bbStart.UseVisualStyleBackColor = true;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 262);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoadForm";
            this.Text = "LoadData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadForm_FormClosing);
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bbStart;
        private System.Windows.Forms.Button bbStop;
        private System.Windows.Forms.Button bbClose;
    }
}
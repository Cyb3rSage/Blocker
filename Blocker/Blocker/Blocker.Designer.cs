namespace Blocker
{
    partial class frmBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlock));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbAdd = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstbWebsites = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(73, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbAdd
            // 
            this.txtbAdd.AcceptsReturn = true;
            this.txtbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbAdd.Location = new System.Drawing.Point(12, 12);
            this.txtbAdd.Name = "txtbAdd";
            this.txtbAdd.Size = new System.Drawing.Size(240, 20);
            this.txtbAdd.TabIndex = 3;
            this.txtbAdd.Text = "Input Website Here";
            this.txtbAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbAdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(73, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbWebsites
            // 
            this.lstbWebsites.FormattingEnabled = true;
            this.lstbWebsites.Location = new System.Drawing.Point(12, 38);
            this.lstbWebsites.Name = "lstbWebsites";
            this.lstbWebsites.Size = new System.Drawing.Size(240, 160);
            this.lstbWebsites.TabIndex = 7;
            this.lstbWebsites.SelectedIndexChanged += new System.EventHandler(this.lstbWebsites_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(101, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmBlock
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 290);
            this.Controls.Add(this.txtbAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstbWebsites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Blocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmBlock_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstbWebsites;
        private System.Windows.Forms.Button btnRemove;
    }
}


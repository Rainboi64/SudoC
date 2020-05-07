namespace SudoC_Studio.Subforms
{
    partial class OptionDialog
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
            this.tbCompilerFile = new System.Windows.Forms.TextBox();
            this.lCompilerFile = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCompilerFile
            // 
            this.tbCompilerFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbCompilerFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCompilerFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tbCompilerFile.Location = new System.Drawing.Point(12, 26);
            this.tbCompilerFile.Name = "tbCompilerFile";
            this.tbCompilerFile.Size = new System.Drawing.Size(400, 20);
            this.tbCompilerFile.TabIndex = 0;
            // 
            // lCompilerFile
            // 
            this.lCompilerFile.AutoSize = true;
            this.lCompilerFile.Location = new System.Drawing.Point(12, 9);
            this.lCompilerFile.Name = "lCompilerFile";
            this.lCompilerFile.Size = new System.Drawing.Size(79, 13);
            this.lCompilerFile.TabIndex = 1;
            this.lCompilerFile.Text = "C Compiler File:";
            // 
            // bOk
            // 
            this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOk.Location = new System.Drawing.Point(307, 52);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(105, 23);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.Location = new System.Drawing.Point(196, 52);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(105, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBrowse.Location = new System.Drawing.Point(85, 52);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(105, 23);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // OptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(424, 84);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lCompilerFile);
            this.Controls.Add(this.tbCompilerFile);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCompilerFile;
        private System.Windows.Forms.Label lCompilerFile;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bBrowse;
    }
}
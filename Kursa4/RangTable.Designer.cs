namespace Kursa4
{
    partial class RangTable
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
            this.listBoxRang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxRang
            // 
            this.listBoxRang.FormattingEnabled = true;
            this.listBoxRang.ItemHeight = 16;
            this.listBoxRang.Location = new System.Drawing.Point(-1, 0);
            this.listBoxRang.Name = "listBoxRang";
            this.listBoxRang.Size = new System.Drawing.Size(290, 452);
            this.listBoxRang.TabIndex = 0;
            // 
            // RangTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.listBoxRang);
            this.Name = "RangTable";
            this.Text = "RangTable";
            this.Load += new System.EventHandler(this.RangTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRang;
    }
}
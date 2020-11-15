namespace Kursa4
{
    partial class pvpKillsTable
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
            this.listBoxpvpKills = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxpvpKills
            // 
            this.listBoxpvpKills.FormattingEnabled = true;
            this.listBoxpvpKills.ItemHeight = 16;
            this.listBoxpvpKills.Location = new System.Drawing.Point(0, -1);
            this.listBoxpvpKills.Name = "listBoxpvpKills";
            this.listBoxpvpKills.Size = new System.Drawing.Size(290, 452);
            this.listBoxpvpKills.TabIndex = 1;
            // 
            // pvpKillsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.listBoxpvpKills);
            this.Name = "pvpKillsTable";
            this.Text = "pvpKillsTable";
            this.Load += new System.EventHandler(this.pvpKillsTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxpvpKills;
    }
}
namespace ScreenShot
{
    partial class frmFragment
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFragment));
            this.panelFragment = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFragment
            // 
            this.panelFragment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFragment.AutoSize = true;
            this.panelFragment.BackColor = System.Drawing.Color.Blue;
            this.panelFragment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelFragment.Location = new System.Drawing.Point(0, 0);
            this.panelFragment.Margin = new System.Windows.Forms.Padding(0);
            this.panelFragment.Name = "panelFragment";
            this.panelFragment.Size = new System.Drawing.Size(304, 281);
            this.panelFragment.TabIndex = 0;
            this.panelFragment.DoubleClick += new System.EventHandler(this.panelFragment_DoubleClick);
            // 
            // frmFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.panelFragment);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFragment";
            this.Text = "Фрагмент";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFragment;
    }
}
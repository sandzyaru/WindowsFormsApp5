namespace WindowsFormsApp5
{
    partial class LWP04Children
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxChildren = new System.Windows.Forms.TextBox();
            this.CB = new System.Windows.Forms.ComboBox();
            this.LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(362, 121);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(150, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxChildren
            // 
            this.TextBoxChildren.Location = new System.Drawing.Point(12, 122);
            this.TextBoxChildren.Name = "TextBoxChildren";
            this.TextBoxChildren.Size = new System.Drawing.Size(287, 22);
            this.TextBoxChildren.TabIndex = 1;
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(12, 12);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(156, 24);
            this.CB.TabIndex = 2;
            this.CB.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 16;
            this.LB.Location = new System.Drawing.Point(190, 12);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(322, 100);
            this.LB.TabIndex = 3;
            this.LB.SelectedIndexChanged += new System.EventHandler(this.LB_SelectedIndexChanged);
            // 
            // LWP04Children
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 167);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.TextBoxChildren);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LWP04Children";
            this.Text = "Работа с окнами (C#) :: Подчинённая форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LWP04Children_FormClosing);
            this.Load += new System.EventHandler(this.LWP04Children_Load);
            this.MouseEnter += new System.EventHandler(this.LWP04Children_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        public System.Windows.Forms.TextBox TextBoxChildren;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.ListBox LB;
    }
}
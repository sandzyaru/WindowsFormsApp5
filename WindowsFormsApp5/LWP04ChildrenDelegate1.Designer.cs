namespace WindowsFormsApp5
{
    partial class LWP04ChildrenDelegate1
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
            this.TextBoxChildrenDelegate1 = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxChildrenDelegate1
            // 
            this.TextBoxChildrenDelegate1.Location = new System.Drawing.Point(12, 28);
            this.TextBoxChildrenDelegate1.Name = "TextBoxChildrenDelegate1";
            this.TextBoxChildrenDelegate1.Size = new System.Drawing.Size(287, 22);
            this.TextBoxChildrenDelegate1.TabIndex = 3;
            this.TextBoxChildrenDelegate1.TextChanged += new System.EventHandler(this.TextBoxChildrenDelegate1_TextChanged);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(320, 28);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(150, 23);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Clic);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Способ №1: Передача метода в конструктор";
            // 
            // LWP04ChildrenDelegate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 53);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxChildrenDelegate1);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LWP04ChildrenDelegate1";
            this.ShowInTaskbar = false;
            this.Text = "Работа с окнами (C#) :: Подчинённая форма для делегата № 1";
            this.Load += new System.EventHandler(this.LWP04ChildrenDelegate1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBoxChildrenDelegate1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label label1;
    }
}
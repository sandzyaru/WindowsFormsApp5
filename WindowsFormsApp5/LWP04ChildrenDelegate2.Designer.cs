namespace WindowsFormsApp5
{
    partial class LWP04ChildrenDelegate2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxChildrenDelegate2 = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Способ №2: Передача метода в конструктор";
            // 
            // TextBoxChildrenDelegate2
            // 
            this.TextBoxChildrenDelegate2.Location = new System.Drawing.Point(14, 24);
            this.TextBoxChildrenDelegate2.Name = "TextBoxChildrenDelegate2";
            this.TextBoxChildrenDelegate2.Size = new System.Drawing.Size(287, 22);
            this.TextBoxChildrenDelegate2.TabIndex = 6;
            this.TextBoxChildrenDelegate2.TextChanged += new System.EventHandler(this.TextBoxChildrenDelegate2_TextChanged);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(322, 24);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(150, 23);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LWP04ChildrenDelegate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 53);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxChildrenDelegate2);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LWP04ChildrenDelegate2";
            this.ShowInTaskbar = false;
            this.Text = "Работа с окнами (C#) :: Подчинённая форма для делегата № 2";
            this.Load += new System.EventHandler(this.LWP04ChildrenDelegate2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextBoxChildrenDelegate2;
        private System.Windows.Forms.Button ButtonClose;
    }
}
namespace WindowsFormsApp5
{
    partial class LWP04Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LWP04Main));
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonShowChildren = new System.Windows.Forms.Button();
            this.ButtonShowChildrenDelegate1 = new System.Windows.Forms.Button();
            this.ButtonShowChildrenDelegate2 = new System.Windows.Forms.Button();
            this.TextBoxMain = new System.Windows.Forms.TextBox();
            this.LBMain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonShowChildren
            // 
            this.ButtonShowChildren.Location = new System.Drawing.Point(323, 226);
            this.ButtonShowChildren.Name = "ButtonShowChildren";
            this.ButtonShowChildren.Size = new System.Drawing.Size(173, 23);
            this.ButtonShowChildren.TabIndex = 1;
            this.ButtonShowChildren.Text = "Подчинённая форма";
            this.Hint.SetToolTip(this.ButtonShowChildren, "Передача параметра через метод в конструкторе");
            this.ButtonShowChildren.UseVisualStyleBackColor = true;
            this.ButtonShowChildren.Click += new System.EventHandler(this.ButtonShowChildren_Click);
            // 
            // ButtonShowChildrenDelegate1
            // 
            this.ButtonShowChildrenDelegate1.Location = new System.Drawing.Point(12, 226);
            this.ButtonShowChildrenDelegate1.Name = "ButtonShowChildrenDelegate1";
            this.ButtonShowChildrenDelegate1.Size = new System.Drawing.Size(150, 23);
            this.ButtonShowChildrenDelegate1.TabIndex = 3;
            this.ButtonShowChildrenDelegate1.Text = "Для делегата № 1";
            this.Hint.SetToolTip(this.ButtonShowChildrenDelegate1, "Передача параметра через метод в конструкторе");
            this.ButtonShowChildrenDelegate1.UseVisualStyleBackColor = true;
            this.ButtonShowChildrenDelegate1.Click += new System.EventHandler(this.ButtonShowChildrenDelegate1_Click);
            // 
            // ButtonShowChildrenDelegate2
            // 
            this.ButtonShowChildrenDelegate2.Location = new System.Drawing.Point(167, 226);
            this.ButtonShowChildrenDelegate2.Name = "ButtonShowChildrenDelegate2";
            this.ButtonShowChildrenDelegate2.Size = new System.Drawing.Size(150, 23);
            this.ButtonShowChildrenDelegate2.TabIndex = 4;
            this.ButtonShowChildrenDelegate2.Text = "Для делегата № 2";
            this.Hint.SetToolTip(this.ButtonShowChildrenDelegate2, "Передача параметра через класс делегата");
            this.ButtonShowChildrenDelegate2.UseVisualStyleBackColor = true;
            this.ButtonShowChildrenDelegate2.TextChanged += new System.EventHandler(this.TextBoxChildrenDelegate2_TextChanged);
            this.ButtonShowChildrenDelegate2.Click += new System.EventHandler(this.ButtonShowChildrenDelegate2_Click);
            // 
            // TextBoxMain
            // 
            this.TextBoxMain.Location = new System.Drawing.Point(323, 181);
            this.TextBoxMain.Name = "TextBoxMain";
            this.TextBoxMain.Size = new System.Drawing.Size(173, 22);
            this.TextBoxMain.TabIndex = 2;
            this.TextBoxMain.TextChanged += new System.EventHandler(this.TextBoxMain_TextChanged);
            // 
            // LBMain
            // 
            this.LBMain.FormattingEnabled = true;
            this.LBMain.ItemHeight = 16;
            this.LBMain.Location = new System.Drawing.Point(323, 74);
            this.LBMain.Name = "LBMain";
            this.LBMain.Size = new System.Drawing.Size(173, 84);
            this.LBMain.TabIndex = 5;
            this.LBMain.SelectedIndexChanged += new System.EventHandler(this.LB_SelectedIndexChanged);
            this.LBMain.DoubleClick += new System.EventHandler(this.LBMain_MouseDoubleClick);
            // 
            // LWP04Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 320);
            this.Controls.Add(this.LBMain);
            this.Controls.Add(this.ButtonShowChildrenDelegate2);
            this.Controls.Add(this.ButtonShowChildrenDelegate1);
            this.Controls.Add(this.TextBoxMain);
            this.Controls.Add(this.ButtonShowChildren);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LWP04Main";
            this.Text = "Windows Forms (C#)";
            this.Load += new System.EventHandler(this.LWP04Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Button ButtonShowChildren;
        public System.Windows.Forms.TextBox TextBoxMain;
        private System.Windows.Forms.Button ButtonShowChildrenDelegate1;
        private System.Windows.Forms.Button ButtonShowChildrenDelegate2;
        private System.Windows.Forms.ListBox LBMain;
    }
}


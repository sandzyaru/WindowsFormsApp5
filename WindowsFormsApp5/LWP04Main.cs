using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace WindowsFormsApp5
{
    public partial class LWP04Main : Form
    {
        LWP04Children dlg = new LWP04Children();
        public LWP04Main()
        {
            InitializeComponent();
            NewDelegate2Out.EventHandler = new NewDelegate2Out.NewEventOut(TextBoxNewDelegate2Out);
        }
        private void TextBoxChildrenDelegate2_TextChanged(object sender, EventArgs e)
        {
            /* Срабатывает делегат NewDelegate2Out при получения события изменений текста этого поля
             * и в метод (на главную форму) отправляется значение этого поля
             * То есть изменение текста приводит к ВЫЗОВУ события EventHandler и отправку через делегат данных текстового поля */
            NewDelegate2Out.EventHandler(TextBoxMain.Text);
        }


        private void ButtonShowChildren_Click(object sender, EventArgs e)
        {
            if (!dlg.Visible)
            {
                dlg.Show(this);
            }
                
            dlg.ComboText = TextBoxMain.Text; // Вызываем строковый параметр ComboText и метод set
            dlg.ListText = TextBoxMain.Text;
            if (dlg.ComboText != "")
                LBMain.Items.Add(dlg.ComboText);

        }



        private void TextBoxMain_TextChanged(object sender, EventArgs e)
        {
            dlg.TextBoxChildren.Text = TextBoxMain.Text; // При изменении текста в поле TextBoxMain тоже самое происходит в поле TextBoxChildren

        }
        private void LWP04Main_Load(object sender, EventArgs e)
        {
            dlg.TextBoxChildren.TextChanged += new EventHandler(LWP04Main_Load); // Определяем, что прозизошло изменение текста в TextBoxChildren и вызываем событие Load
            TextBoxMain.Text = dlg.TextBoxChildren.Text;

        }

        private void ButtonShowChildrenDelegate1_Click(object sender, EventArgs e)
        {
            /* Создаём экземпляр класса формы LWP04ChildrenDelegate1, вызывает конструктор
* Вместе с формой создаём экземпляр делегата с вызовом метода TextBoxNewDelegate1() */
            LWP04ChildrenDelegate1 D1 = new LWP04ChildrenDelegate1(new NewDelegate1(TextBoxNewDelegate1));
            D1.ShowDialog(); // Вызываем модальный диалог нашей формы
            MessageBox.Show("Текст который был введён в форме:\n\n" + D1.Text1, D1.Text + " :: Результат выполнения"); // Возвращаем с формы переменную Text1 И показываем её в окошке MessageBox.Show
            TextBoxMain.Text = D1.Text1; // Отправляем переменную в поле TextBoxMan

        }
        string TextBoxNewDelegate1()
        {
            // Метод возвращает значение TextBoxMain, нужен для работы делегата
            return TextBoxMain.Text;
        }



        private void ButtonShowChildrenDelegate2_Click(object sender, EventArgs e)
        {
            LWP04ChildrenDelegate2 D2 = new LWP04ChildrenDelegate2(new NewDelegate2In(TextBoxNewDelegate2));
            D2.ShowDialog(); // Вызываем модальный диалог нашей формы
        }
        void TextBoxNewDelegate2Out(String Text)
        {
            /* Основной обработчик передачи параметра, вызывается всякий раз когда происходит событий обновления текста поле дочерней формы
* Вызывает MessageBox.Show с главной формы, что важно, сообщая параметр с дочерней формы */
            MessageBox.Show("Текст который был введён в форме:\n\n" + Text, D2.Text + " :: Результат выполнения");
            TextBoxMain.Text = Text; // Отправляем полученную переменную в поле TextBoxMan (выполняется динамически)

        }
          string TextBoxNewDelegate2()
        {
            // Метод возвращает значение TextBoxMain, нужен для работы делегата
            return this.TextBoxMain.Text;
        }

        private void LBMain_MouseDoubleClick(object sender, EventArgs e)
        {
            if (dlg.ComboText != "") // Проверяем значение которое добавляем (должно быть не пусто)
                LBMain.Items.Add(dlg.ComboText);
            if (dlg.ListText != "") // Проверяем значение которое добавляем (должно быть не пусто)
                LBMain.Items.Add(dlg.ListText);
            if (LBMain.Items.Count > 4) // Очищаем все значения элемента, если их число больше 4
                LBMain.Items.Clear();

        }

        private void LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Close();
        }
    }
}

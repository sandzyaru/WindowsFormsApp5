using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class LWP04ChildrenDelegate1 : Form
    {
        public string Text1;
        private NewDelegate1 D1;

        public LWP04ChildrenDelegate1(NewDelegate1 sender)
        {
            InitializeComponent();
            D1 = sender;
        }


        private void TextBoxChildrenDelegate1_TextChanged(object sender, EventArgs e)
        {
            Text1 = TextBoxChildrenDelegate1.Text; // Присваиваем переменной обратной передачи значение текстового поля
        }

        private void LWP04ChildrenDelegate1_Load(object sender, EventArgs e)
        {
            /* Вызываем созданный экземпляр класса NewDelegate1
 * После вызова экземпляр вытаскивает из главной формы метод, а точнее переменную TextBoxNewDelegate1
 * Далее делегат становится переменной, которую мы отправляем в TextBoxChildren этой формы
 * Сама переменная делегата является возвращаемой строкой от TextBoxMain */
            TextBoxChildrenDelegate1.Text = D1();
        }



        private void ButtonClose_Clic(object sender, EventArgs e)
        {
            Close();
            Dispose();

        }
    }
}

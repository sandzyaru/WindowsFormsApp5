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
    public partial class LWP04ChildrenDelegate2 : Form
    {
        public string Text2;
        private NewDelegate2In D2;
     

    
        public LWP04ChildrenDelegate2(NewDelegate2In newDelegate2In)
        {
            InitializeComponent();

            D2 = newDelegate2In;
        }

        private void TextBoxChildrenDelegate2_TextChanged(object sender, EventArgs e)
        {
            Text2 = TextBoxChildrenDelegate2.Text; // Присваиваем переменной обратной передачи значение текстового поля
        }

        private void LWP04ChildrenDelegate2_Load(object sender, EventArgs e)
        {
            TextBoxChildrenDelegate2.Text = D2();

        }



        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

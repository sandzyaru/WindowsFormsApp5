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
    public partial class LWP04Children : Form
    {
        public LWP04Children()
        {
            InitializeComponent();
        }

        private void LWP04Children_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Определяем кто закрывает приложение
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel = true;
            }
        }
     


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close(); // Кнопка Закрыть
           // Dispose(); // Уничтожаем окно и все его параметры до следующего вызова конструктора формы
        }
        public string ComboText
        {
            get { return CB.Text; }
            set { if (value != "") CB.Items.Add("ComboBox: [" + value + "]"); }
        }
        public string ListText
        {
            get { return LB.Text; }
            set { if (value != "") LB.Items.Add("ListBox: [" + value + "]"); }
        }


        private void LWP04Children_Load(object sender, EventArgs e)
        {

        }

        private void LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LWP04Children_MouseEnter(object sender, EventArgs e)
        {
            if (CB.Items.Count > 4)
                CB.Items.Clear();
            if (LB.Items.Count > 4)
                LB.Items.Clear();

        }
    }
}

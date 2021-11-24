using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_формы
{
    public partial class Clients : Form
    {
        bool Upd_;
        public bool Upd { get { return Upd_; } }
        public string Client_Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Client_Adres
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public Clients()
        {
            InitializeComponent();
            Upd_ = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранить
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Upd_ = true;
                Close();
            }
            else MessageBox.Show("Заполните все поля!", "Предупреждение");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Отменить
            Upd_ = false;
            Close();
        }
    }
}

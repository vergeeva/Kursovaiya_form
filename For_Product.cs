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
    public partial class For_Product : Form
    {
        bool Upd_;
        public bool Upd { get { return Upd_; } }
        public string Client_Name
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public int Client_ID
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }

        }

        public int Count_of_Products
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = Convert.ToString(value); }
        }
        int ID_Client;
        public For_Product(int Client_ID)
        {
            InitializeComponent();
            ID_Client = Client_ID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранить
            if (textBox1.Text != "" && comboBox1.Text != "")
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

        private void For_Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "variantDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.variantDataSet.Клиенты);
            comboBox1.SelectedValue = ID_Client;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

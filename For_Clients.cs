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
    public partial class For_Clients : Form
    {
        bool Upd_;
        public bool Upd { get { return Upd_; } }
        public For_Clients(int ID)
        {
            InitializeComponent();
            int Product_ID = ID;

        }
        public int Count_of_Products
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = Convert.ToString(value); }
        }

        public string Product_Name
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public int Product_ID
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }

        }

        private void For_Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "variantDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.variantDataSet.Товары);
            comboBox1.SelectedValue = Product_ID;

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
    }
}

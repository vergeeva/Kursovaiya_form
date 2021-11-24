using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Курсовая_формы
{
    public partial class Form3 : Form
    {
        private Excel.Application excelapp; // Программа Excel
        private Excel.Window excelWindow; // Окно программы Excel
        private Excel.Workbooks excelappworkbooks; // Рабочие книги
        private Excel.Workbook excelappworkbook; // Рабочая книга
        private Excel.Sheets excelsheets; // Рабочие листы
        private Excel.Worksheet excelworksheet; // Рабочий лист
        private Excel.Range excelcells; // Диапазон ячеек или ячейка

        private Word.Application WordApp; // Программа Word
        private Word.Documents WordDocuments; // Документы
        private Word.Document WordDocument; // Документ
        private Word.Paragraphs WordParagraphs; // Параграфы
        private Word.Paragraph WordParagraph; // Параграф
        private Word.Range WordRange; // Выделенный диапазон
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "variantDataSet.Реализация_запрос". При необходимости она может быть перемещена или удалена.
            this.реализация_запросTableAdapter.Fill(this.variantDataSet.Реализация_запрос);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавить покупку
            DataRowView drv = реализациязапросBindingSource.Current as DataRowView;
            //int Client_ID = Convert.ToInt32(drv.Row["Код_клиента"]);
            For_Realize frm = new For_Realize(1,1);
            frm.ShowDialog();
            if (frm.Upd)
            {
                реализация_запросTableAdapter.Connection.Open(); //Открываем подключение
                //Задаем параметры запроса
                реализация_запросTableAdapter.Adapter.InsertCommand.Parameters["Код_клиента"].Value = frm.Client_ID;
                реализация_запросTableAdapter.Adapter.InsertCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                реализация_запросTableAdapter.Adapter.InsertCommand.Parameters["Код_товара"].Value = frm.Product_ID;
                //Выполняем
                try
                {
                    реализация_запросTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    реализация_запросTableAdapter.Fill(variantDataSet.Реализация_запрос);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно добавить объект");
                }
                реализация_запросTableAdapter.Connection.Close(); //Закрываем подключение
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Изменить покупку
            //Код товара Код клиента количество
            DataRowView drv = реализациязапросBindingSource.Current as DataRowView;
            //String Client_Name = Convert.ToString(drv.Row["ФИО"]);
            //int ID_CLient = Convert.ToInt32(drv.Row["Код_клиента"]);
            int Count_of_Products = Convert.ToInt32(drv.Row["Количество"]);
            int ID_product = Convert.ToInt32(drv.Row["Код_товара"]);
            int ID_client = Convert.ToInt32(drv.Row["Код_клиента"]);
            For_Realize frm = new For_Realize(ID_product, ID_client);
            
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);

            frm.Count_of_Products = Count_of_Products;
            frm.ShowDialog();
            if (frm.Upd)
            {
                реализация_запросTableAdapter.Connection.Open(); //Открываем подключение
                //Код клиента
                реализация_запросTableAdapter.Adapter.UpdateCommand.Parameters["Код_клиента"].Value = frm.Client_ID;
                //Код товара
                реализация_запросTableAdapter.Adapter.UpdateCommand.Parameters["Код_товара"].Value = frm.Product_ID;
                //Количество
                реализация_запросTableAdapter.Adapter.UpdateCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                //Код реализации
                реализация_запросTableAdapter.Adapter.UpdateCommand.Parameters["Original_Код_реализации"].Value = Real_ID;

                реализация_запросTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                реализация_запросTableAdapter.Fill(variantDataSet.Реализация_запрос);
                реализация_запросTableAdapter.Connection.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Удалить покупку
            DataRowView drv = реализациязапросBindingSource.Current as DataRowView;
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);
            int ID_product = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var result = MessageBox.Show("Удалить покупку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                реализация_запросTableAdapter.Connection.Open(); //Открываем подключение
                реализация_запросTableAdapter.Adapter.DeleteCommand.Parameters["Код_реализации"].Value = Real_ID;
                реализация_запросTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                реализация_запросTableAdapter.Fill(variantDataSet.Реализация_запрос);
                реализация_запросTableAdapter.Connection.Close();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            DataRowView drv = реализациязапросBindingSource.Current as DataRowView;
            //Передать в Excel
            // Запустим Excel
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            // В книге, которую создадим позже, будет 3 листа
            excelapp.SheetsInNewWorkbook = 3;
            // Создадим книгу
            excelapp.Workbooks.Add(Type.Missing);
            // Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            // Получаем ссылку на рабочие листы книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets[1];
            // Сделаем первый лист активным
            excelworksheet.Activate();
            excelworksheet.Name = "Реализация товаров";
            // Запишем в ячейку A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "Покупатель";
            // Запишем в ячейку B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "Наименование товара";
            // Запишем в ячейку C1
            excelcells = excelworksheet.get_Range("C1", "C1");
            excelcells.Value2 = "Цена за единицу товара";
            // Запишем в ячейку D1
            excelcells = excelworksheet.get_Range("D1", "D1");
            excelcells.Value2 = "Количество";
            // Запишем в ячейку E1
            excelcells = excelworksheet.get_Range("E1", "E1");
            excelcells.Value2 = "Стоимость";
            //Сделаем жирный шрифт
            excelcells = excelworksheet.get_Range("A1", "E1");
            excelcells.Font.Size = 14;
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells.Font.Bold = 5;

            string[] c = { "A", "B", "C", "D" , "E"};
            // Цикл по строкам таблицы
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                // Цикл по столбцам
                for (int j = 0; j < c.Length; j++)
                {
                    // Вывод в ячейку i+2, j Excel-я содержимого соответствующей ячейки
                    // dataGridView1 
                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +
                    Convert.ToString(i + 2));
                    excelcells.Value2 = dataGridView1.Rows[i].Cells[j + 3].Value.ToString();
                    excelcells.Font.Size = 13;
                    excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
                } // for
            } // for

            excelcells = excelworksheet.get_Range("A1", "E" +
Convert.ToSingle(dataGridView1.RowCount));
            Excel.XlBordersIndex bi = Excel.XlBordersIndex.xlInsideVertical;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlInsideHorizontal;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeLeft;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeTop;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeBottom;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeRight;
            excelcells.Borders[bi].LineStyle = 1;
            excelcells = excelworksheet.get_Range("A1", "E" + Convert.ToSingle(dataGridView1.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Columns.AutoFit();
        }
    }
}

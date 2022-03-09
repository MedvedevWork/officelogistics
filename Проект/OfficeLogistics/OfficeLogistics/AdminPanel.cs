using OfficeLogistics.officelogisticsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeLogistics
{
    public partial class AdminPanel : Form
    {
        int idUserNum;
        int selectedRow, idItem;

        string com = @"Data Source=localhost;Initial Catalog=officelogistics; Integrated Security=True";

        officelogisticsDataSet.ItemsDataTable itemsData;
        officelogisticsDataSet.ItemsRow itemsRow;

        public AdminPanel(int idUser)
        {
            idUserNum = idUser;
            InitializeComponent();


            SqlConnection connect = new SqlConnection();

            connect.ConnectionString = com;
            connect.Open();
        }

        //DataGridView mainTable = new DataGridView();

        public void List(int idUser)
        {
            Form admin = this;

            ItemsTableAdapter itemsTableAdapter = new ItemsTableAdapter();
            officelogisticsDataSet.ItemsDataTable dataEvents = itemsTableAdapter.GetData();

            dataEvents = new officelogisticsDataSet.ItemsDataTable();
            itemsTableAdapter.Fill(dataEvents);

          
            mainTable.Location = new Point(10, 10);
            mainTable.Size = new Size(600, 300);

            //var filter = dataEvents.Where(rec => rec.Author == idUser);

            mainTable.DataSource = dataEvents.CopyToDataTable(); //filter.CopyToDataTable();
            mainTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainTable.Select();

            mainTable.AllowUserToAddRows = false;
            mainTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainTable.RowHeadersVisible = false;
            mainTable.ReadOnly = true;

            mainTable.ScrollBars = ScrollBars.Vertical;
            mainTable.AllowUserToResizeColumns = false;
            admin.Controls.Add(mainTable);
            //shelf.Show();

            mainTable.Columns["ID"].Visible = false;
            mainTable.Columns["Shelf"].HeaderText = "Полка";
            mainTable.Columns["Name"].HeaderText = "Наименование";
            mainTable.Columns["Count"].HeaderText = "Количество";
            mainTable.Columns["fCost"].HeaderText = "Закупочная цена";
            mainTable.Columns["sCost"].HeaderText = "Цена продажи";

            found.Text = "Количество записей: " + mainTable.RowCount + " из " + mainTable.RowCount;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            List(idUserNum);
        }

        private void search_TextChanged(object sender, EventArgs e)  
        {
            
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            EditStorage es = new EditStorage(1, idItem);

            this.Hide();
            es.ShowDialog();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            EditStorage es = new EditStorage(2, idItem);

            this.Hide();
            es.ShowDialog();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                itemsData = itemsTableAdapter1.GetData();
                itemsRow = itemsData.ElementAt(idItem);
                itemsTableAdapter1.Delete(itemsRow.ID, itemsRow.Shelf, itemsRow.Name, itemsRow.Count, itemsRow.fCost, itemsRow.sCost);

                MessageBox.Show("Полка освобождена");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void mainTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;

            selectedRow = numRow;

            idItem = Convert.ToInt32(mainTable.Rows[numRow].Cells[0].Value);
        }
    }
}

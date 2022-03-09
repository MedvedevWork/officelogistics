using OfficeLogistics.officelogisticsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeLogistics
{
    public partial class Shelfs : Form
    {
        int idUserNum;

        public Shelfs(int idUser)
        {
            idUserNum = idUser;
            InitializeComponent();
        }

        public void List(int idUser) // Showing all by ID
        {
            Form shelf = this;

            ItemsTableAdapter itemsTableAdapter = new ItemsTableAdapter();
            officelogisticsDataSet.ItemsDataTable dataEvents = itemsTableAdapter.GetData();

            dataEvents = new officelogisticsDataSet.ItemsDataTable();
            itemsTableAdapter.Fill(dataEvents);

            //DataGridView mainTable = new DataGridView();
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

            mainTable.AllowUserToResizeColumns = false;
            shelf.Controls.Add(mainTable);
            mainTable.ScrollBars = ScrollBars.Vertical;
            //shelf.Show();

            mainTable.Columns["ID"].Visible = false;
            mainTable.Columns["Shelf"].HeaderText = "Полка";
            mainTable.Columns["Name"].HeaderText = "Наименование";
            mainTable.Columns["Count"].HeaderText = "Количество";
            mainTable.Columns["fCost"].HeaderText = "Закупочная цена";
            mainTable.Columns["sCost"].HeaderText = "Цена продажи";

            found.Text = "Количество записей: " + mainTable.RowCount + " из " + mainTable.RowCount;
        }

        private void Shelfs_Load(object sender, EventArgs e)
        {
            List(idUserNum);
        }
    }
}

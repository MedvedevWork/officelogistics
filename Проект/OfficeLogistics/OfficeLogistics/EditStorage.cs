using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeLogistics.officelogisticsDataSetTableAdapters;

namespace OfficeLogistics
{
    public partial class EditStorage : Form
    {
        public int mode, item_id;

        public EditStorage(int m, int item)
        {
            mode = m;
            item_id = item;
            InitializeComponent();
        }

        officelogisticsDataSet.ItemsDataTable itemsData;
        officelogisticsDataSet.ItemsRow itemsRow;

        private void goChange_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:

                    itemsData = itemsTableAdapter1.GetData();
                    itemsRow = itemsData.FindByID(item_id);

                    try
                    {
                        itemsTableAdapter1.Insert(itemsData.Count + 1, Convert.ToInt32(shelf.Text), name.Text, Convert.ToInt32(count.Text), Convert.ToInt32(fCost), Convert.ToInt32(sCost));
                        MessageBox.Show("Полка успешно зарезервирована, товар добавлен в БД");
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильность введённых данных");
                    }

                    break;

                case 2:

                    itemsData = itemsTableAdapter1.GetData();
                    itemsRow = itemsData.FindByID(item_id);

                    try
                    {
                        itemsRow.Shelf = Convert.ToInt32(shelf.Text);
                        itemsRow.Name = name.Text;
                        itemsRow.Count = Convert.ToInt32(count.Text);
                        itemsRow.fCost = Convert.ToInt32(fCost.Text);
                        itemsRow.sCost = Convert.ToInt32(sCost.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильность введённых данных");
                    }

                    break;
            }
        }

        private void EditStorage_Load(object sender, EventArgs e)
        {
            int go = item_id;

            switch (mode)
            {
                case 1:	// Цель - добавление

                    this.Text = "Добавление паллета на склад";
                    break;

                case 2:

                    this.Text = "Коррекция значений";

                    itemsData = itemsTableAdapter1.GetData();
                    itemsRow = itemsData.FindByID(item_id);

                    shelf.Text = itemsRow.Shelf.ToString();
                    name.Text = itemsRow.Name;
                    count.Text = itemsRow.Count.ToString();
                    fCost.Text = itemsRow.fCost.ToString();
                    sCost.Text = itemsRow.sCost.ToString();

                    break;
            }
        }
    }
}

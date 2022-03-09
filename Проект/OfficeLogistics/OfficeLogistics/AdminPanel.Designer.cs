
namespace OfficeLogistics
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.found = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.addItem = new System.Windows.Forms.Button();
            this.editItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.itemsTableAdapter1 = new OfficeLogistics.officelogisticsDataSetTableAdapters.ItemsTableAdapter();
            this.otchet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // found
            // 
            this.found.AutoSize = true;
            this.found.Location = new System.Drawing.Point(469, 327);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(117, 13);
            this.found.TabIndex = 1;
            this.found.Text = "Количество записей: ";
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(12, 31);
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(630, 281);
            this.mainTable.TabIndex = 2;
            this.mainTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTable_RowEnter);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(12, 318);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(104, 31);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Добавить паллет";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // editItem
            // 
            this.editItem.Location = new System.Drawing.Point(122, 318);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(184, 31);
            this.editItem.TabIndex = 4;
            this.editItem.Text = "Редактировать выбранную полку";
            this.editItem.UseVisualStyleBackColor = true;
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(312, 318);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(61, 31);
            this.deleteItem.TabIndex = 5;
            this.deleteItem.Text = "Удалить";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // otchet
            // 
            this.otchet.Location = new System.Drawing.Point(379, 318);
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(66, 31);
            this.otchet.TabIndex = 6;
            this.otchet.Text = "Отчёт";
            this.otchet.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.otchet);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.editItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.found);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.Text = "Администратор - склад";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label found;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button editItem;
        private System.Windows.Forms.Button deleteItem;
        private officelogisticsDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private System.Windows.Forms.Button otchet;
    }
}
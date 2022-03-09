
namespace OfficeLogistics
{
    partial class EditStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStorage));
            this.shelf = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.fCost = new System.Windows.Forms.TextBox();
            this.sCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemsTableAdapter1 = new OfficeLogistics.officelogisticsDataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shelf
            // 
            this.shelf.Location = new System.Drawing.Point(108, 74);
            this.shelf.Name = "shelf";
            this.shelf.Size = new System.Drawing.Size(113, 20);
            this.shelf.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 100);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(113, 31);
            this.name.TabIndex = 1;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(108, 137);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(113, 20);
            this.count.TabIndex = 2;
            // 
            // fCost
            // 
            this.fCost.Location = new System.Drawing.Point(108, 163);
            this.fCost.Name = "fCost";
            this.fCost.Size = new System.Drawing.Size(113, 20);
            this.fCost.TabIndex = 3;
            // 
            // sCost
            // 
            this.sCost.Location = new System.Drawing.Point(108, 189);
            this.sCost.Name = "sCost";
            this.sCost.Size = new System.Drawing.Size(113, 20);
            this.sCost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер полки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Закупочная цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отпускная цена";
            // 
            // goChange
            // 
            this.goChange.Location = new System.Drawing.Point(17, 215);
            this.goChange.Name = "goChange";
            this.goChange.Size = new System.Drawing.Size(204, 23);
            this.goChange.TabIndex = 10;
            this.goChange.Text = "Изменить";
            this.goChange.UseVisualStyleBackColor = true;
            this.goChange.Click += new System.EventHandler(this.goChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OfficeLogistics.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 44);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // EditStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.goChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sCost);
            this.Controls.Add(this.fCost);
            this.Controls.Add(this.count);
            this.Controls.Add(this.name);
            this.Controls.Add(this.shelf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStorage";
            this.Text = "Коррекция значений";
            this.Load += new System.EventHandler(this.EditStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shelf;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox fCost;
        private System.Windows.Forms.TextBox sCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private officelogisticsDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
    }
}
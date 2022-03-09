
namespace OfficeLogistics
{
    partial class Shelfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shelfs));
            this.found = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // found
            // 
            this.found.AutoSize = true;
            this.found.Location = new System.Drawing.Point(207, 331);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(117, 13);
            this.found.TabIndex = 0;
            this.found.Text = "Количество записей: ";
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(12, 12);
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(600, 300);
            this.mainTable.TabIndex = 6;
            // 
            // Shelfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.found);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shelfs";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label found;
        private System.Windows.Forms.DataGridView mainTable;
    }
}
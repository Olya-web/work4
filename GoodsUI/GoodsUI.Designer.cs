
namespace GoodsUI
{
    partial class GoodsUI
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
            this.components = new System.ComponentModel.Container();
            this.addGood = new System.Windows.Forms.Button();
            this.editGood = new System.Windows.Forms.Button();
            this.deleteGood = new System.Windows.Forms.Button();
            this.goodListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addGood
            // 
            this.addGood.Location = new System.Drawing.Point(48, 330);
            this.addGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addGood.Name = "addGood";
            this.addGood.Size = new System.Drawing.Size(100, 28);
            this.addGood.TabIndex = 0;
            this.addGood.Text = "Добавить";
            this.addGood.UseVisualStyleBackColor = true;
            this.addGood.Click += new System.EventHandler(this.addGood_Click);
            // 
            // editGood
            // 
            this.editGood.Location = new System.Drawing.Point(173, 330);
            this.editGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editGood.Name = "editGood";
            this.editGood.Size = new System.Drawing.Size(140, 28);
            this.editGood.TabIndex = 1;
            this.editGood.Text = "Редактировать";
            this.editGood.UseVisualStyleBackColor = true;
            this.editGood.Click += new System.EventHandler(this.editGood_Click);
            // 
            // deleteGood
            // 
            this.deleteGood.Location = new System.Drawing.Point(336, 330);
            this.deleteGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteGood.Name = "deleteGood";
            this.deleteGood.Size = new System.Drawing.Size(100, 28);
            this.deleteGood.TabIndex = 2;
            this.deleteGood.Text = "Удалить";
            this.deleteGood.UseVisualStyleBackColor = true;
            this.deleteGood.Click += new System.EventHandler(this.deleteGood_Click);
            // 
            // goodListBindingSource
            // 
            this.goodListBindingSource.DataSource = typeof(GoodsLibrary.GoodInfo);
            // 
            // goodListDataGridView
            // 
            this.goodListDataGridView.AllowUserToAddRows = false;
            this.goodListDataGridView.AllowUserToDeleteRows = false;
            this.goodListDataGridView.AutoGenerateColumns = false;
            this.goodListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.goodListDataGridView.DataSource = this.goodListBindingSource;
            this.goodListDataGridView.Location = new System.Drawing.Point(48, 23);
            this.goodListDataGridView.Name = "goodListDataGridView";
            this.goodListDataGridView.ReadOnly = true;
            this.goodListDataGridView.RowHeadersWidth = 51;
            this.goodListDataGridView.RowTemplate.Height = 24;
            this.goodListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodListDataGridView.Size = new System.Drawing.Size(916, 260);
            this.goodListDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn6.HeaderText = "Артикль";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Название";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn8.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeliveryName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Способ доставки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DeliveryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "DeliveryID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // GoodsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.goodListDataGridView);
            this.Controls.Add(this.deleteGood);
            this.Controls.Add(this.editGood);
            this.Controls.Add(this.addGood);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GoodsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGood;
        private System.Windows.Forms.Button editGood;
        private System.Windows.Forms.Button deleteGood;
        private System.Windows.Forms.BindingSource goodListBindingSource;
        private System.Windows.Forms.DataGridView goodListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}


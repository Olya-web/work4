
namespace GoodsUI
{
    partial class GoodEdit
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
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label deliveryIDLabel;
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.goodInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryIDComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            deliveryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Location = new System.Drawing.Point(123, 22);
            articleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(50, 17);
            articleLabel.TabIndex = 1;
            articleLabel.Text = "article:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(126, 80);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(125, 140);
            countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(47, 17);
            countLabel.TabIndex = 4;
            countLabel.Text = "count:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(130, 208);
            priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "price:";
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodInfoBindingSource, "article", true));
            this.articleTextBox.Location = new System.Drawing.Point(190, 18);
            this.articleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(371, 22);
            this.articleTextBox.TabIndex = 2;
            // 
            // goodInfoBindingSource
            // 
            this.goodInfoBindingSource.DataSource = typeof(GoodsLibrary.GoodInfo);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodInfoBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(190, 76);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(371, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodInfoBindingSource, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(190, 136);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(371, 22);
            this.countTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodInfoBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(190, 204);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(371, 22);
            this.priceTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(157, 414);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(297, 414);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(87, 266);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(86, 17);
            categoryIDLabel.TabIndex = 10;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodInfoBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.categoryListBindingSource;
            this.categoryIDComboBox.DisplayMember = "Name";
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(190, 263);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(371, 24);
            this.categoryIDComboBox.TabIndex = 11;
            this.categoryIDComboBox.ValueMember = "Id";
            // 
            // deliveryIDLabel
            // 
            deliveryIDLabel.AutoSize = true;
            deliveryIDLabel.Location = new System.Drawing.Point(93, 322);
            deliveryIDLabel.Name = "deliveryIDLabel";
            deliveryIDLabel.Size = new System.Drawing.Size(80, 17);
            deliveryIDLabel.TabIndex = 12;
            deliveryIDLabel.Text = "Delivery ID:";
            // 
            // deliveryIDComboBox
            // 
            this.deliveryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodInfoBindingSource, "DeliveryID", true));
            this.deliveryIDComboBox.DataSource = this.deliveryListBindingSource;
            this.deliveryIDComboBox.DisplayMember = "Name";
            this.deliveryIDComboBox.FormattingEnabled = true;
            this.deliveryIDComboBox.Location = new System.Drawing.Point(190, 319);
            this.deliveryIDComboBox.Name = "deliveryIDComboBox";
            this.deliveryIDComboBox.Size = new System.Drawing.Size(371, 24);
            this.deliveryIDComboBox.TabIndex = 13;
            this.deliveryIDComboBox.ValueMember = "Id";
            // 
            // deliveryListBindingSource
            // 
            this.deliveryListBindingSource.DataSource = typeof(GoodsLibrary.DeliveryList);
            // 
            // goodListBindingSource
            // 
            this.goodListBindingSource.DataSource = typeof(GoodsLibrary.GoodList);
            // 
            // categoryListBindingSource
            // 
            this.categoryListBindingSource.DataSource = typeof(GoodsLibrary.CategoryList);
            // 
            // GoodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(deliveryIDLabel);
            this.Controls.Add(this.deliveryIDComboBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(articleLabel);
            this.Controls.Add(this.articleTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodEdit";
            this.Text = "GoodEdit";
            this.Load += new System.EventHandler(this.GoodEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource goodInfoBindingSource;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.BindingSource categoryListBindingSource;
        private System.Windows.Forms.ComboBox deliveryIDComboBox;
        private System.Windows.Forms.BindingSource deliveryListBindingSource;
        private System.Windows.Forms.BindingSource goodListBindingSource;
    }
}
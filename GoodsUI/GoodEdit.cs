using GoodsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsUI
{
    public partial class GoodEdit : Form
    {
        public GoodInfo _newGood = new GoodInfo();
     

        public GoodEdit()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoodEdit_Load(object sender, EventArgs e)
        {
            goodInfoBindingSource.DataSource = _newGood;
            categoryListBindingSource.DataSource = CategoryList.GetCatogoriesList();
            deliveryListBindingSource.DataSource = DeliveryList.GetDeliveryList(); 

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(_newGood.id > 0)
            {
                _newGood.UpdateGood();
            }else
            {
                _newGood.InsertIntoGoods();
            }
            Close();
        }
    }
}

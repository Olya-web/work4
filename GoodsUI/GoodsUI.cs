using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodsLibrary;

namespace GoodsUI
{
    public partial class GoodsUI : Form
    {
        GoodList _goodsList = new GoodList();

        public GoodsUI()
        {
            InitializeComponent();
        }

        private void GoodsUI_Load(object sender, EventArgs e)
        {
            RefreshGoods();
        }

        void RefreshGoods()
        {
            _goodsList = GoodList.GetGoodList();
            goodListBindingSource.DataSource = _goodsList;
        }

        private void addGood_Click(object sender, EventArgs e)
        {
            GoodEdit newGoodEdit = new GoodEdit();
            newGoodEdit.ShowDialog();
            RefreshGoods();
        }

        private void editGood_Click(object sender, EventArgs e)
        {
            int goodID = (int)goodListDataGridView.SelectedRows[0].Cells[0].Value;
            GoodEdit goodEdit = new GoodEdit();

            foreach (GoodInfo good in _goodsList)
            {
                if(good.id == goodID)
                {
                    good.GetGood(goodID);
                    goodEdit._newGood = good;
                }
            }

            goodEdit.ShowDialog();
            RefreshGoods();
        }

        private void deleteGood_Click(object sender, EventArgs e)
        {
            int goodID = (int)goodListDataGridView.SelectedRows[0].Cells[0].Value;
          
            foreach (GoodInfo good in _goodsList)
            {
                if (good.id == goodID)
                {
                    good.DeleteGood();
                
                }
            }

    
            RefreshGoods();
        }
    }
}

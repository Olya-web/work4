using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public class DeliveryInfo
    {
        private int _id = 0;
        private string _name = "";
        
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}

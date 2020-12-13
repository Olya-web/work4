using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public class GoodList: List<GoodInfo>
    {
        public static GoodList GetGoodList()
        {
            GoodList goodList = new GoodList();
            string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetAllGoods";
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                GoodInfo newGood = new GoodInfo();

                newGood.id = (int)dataReader["id"];
                newGood.article = dataReader["article"].ToString();
                newGood.name = dataReader["name"].ToString();
                newGood.count = (int)dataReader["count"];
                newGood.price = dataReader["price"].ToString();
                newGood.CategoryID = (int)dataReader["categoryID"];
                newGood.CategoryName = dataReader["categoryName"].ToString();
                newGood.DeliveryID = (int)dataReader["deliveryID"];
                newGood.DeliveryName = dataReader["deliveryName"].ToString();
                goodList.Add(newGood);
            }

            connection.Close();

            return goodList;
        }
    }
}

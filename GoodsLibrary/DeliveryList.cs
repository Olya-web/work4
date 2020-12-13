using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public class DeliveryList : List<DeliveryInfo>
    {
        public static DeliveryList GetDeliveryList()
        {

            DeliveryList deliveryList = new DeliveryList();
            string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetDeliveries";
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DeliveryInfo delivery = new DeliveryInfo();

                delivery.Id = (int)dataReader["id"];
                delivery.Name = dataReader["name"].ToString();


                deliveryList.Add(delivery);
            }

            connection.Close();

            return deliveryList;
        }


    }
}

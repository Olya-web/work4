using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GoodsLibrary
{
    public class GoodInfo
    {
        private int _id = 0;
        private string _article = "";
        private string _name = "";
        private int _count = 0;
        private string _price = "";
        private int _deliveryID = 0;
        private int _categoryID = 0;
        private string _deliveryName = "";
        private string _categoryName = "";

        public string DeliveryName
        {
            get
            {
                return _deliveryName;
            }
            set
            {
                _deliveryName = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return _categoryName;

            }
            set
            {
                _categoryName = value;
            }
        }

        public int CategoryID
        {
            get
            {
                return _categoryID;
            }
            set
            {
                _categoryID = value;
            }
        }

        public int DeliveryID
        {
            get
            {
                return _deliveryID;
            }
            set
            {
                _deliveryID = value;
            }
        }


        public int id
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

        public string article
        {
            get
            {
                return _article;
            }
            set
            {
                _article = value; 
            }
        }

        public string name
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

        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public string price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }



        public void InsertIntoGoods()
        {

       
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertIntoGoods";

                command.Parameters.Add(new SqlParameter("@article", _article));
                command.Parameters.Add(new SqlParameter("@name", _name));
                command.Parameters.Add(new SqlParameter("@count", _count));
                command.Parameters.Add(new SqlParameter("@price", _price));
                command.Parameters.Add(new SqlParameter("@deliveryID", _deliveryID));
                command.Parameters.Add(new SqlParameter("@categoryID", _categoryID));
                command.ExecuteNonQuery();
                connection.Close();
      
        }

        public void DeleteGood()
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteGood";

                command.Parameters.Add(new SqlParameter("@id", _id));

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }


        public void UpdateGood()
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateGood";


                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters.Add(new SqlParameter("@article", _article));
                command.Parameters.Add(new SqlParameter("@name", _name));
                command.Parameters.Add(new SqlParameter("@count", _count));
                command.Parameters.Add(new SqlParameter("@price", _price));
                command.Parameters.Add(new SqlParameter("@deliveryID", _deliveryID));
                command.Parameters.Add(new SqlParameter("@categoryID", _categoryID));

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        public void GetGood(int TodoID)
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetGood";


                command.Parameters.Add(new SqlParameter("@id", _id));

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    _id = (int)dataReader["id"];
                    _article = dataReader["article"].ToString();
                    _name = dataReader["name"].ToString();
                    _count = (int)dataReader["count"];
                    _price = dataReader["price"].ToString();
                    _deliveryID = (int)dataReader["deliveryID"];
                    _categoryID = (int)dataReader["categoryID"];

                }


                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public class CategoryList: List<CategoryInfo>
    {
        public static CategoryList GetCatogoriesList()
        {

            CategoryList categoryList = new CategoryList();
            string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Goods;Integrated Security=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetCategories";
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                CategoryInfo category = new CategoryInfo();

                category.Id = (int)dataReader["id"];
                category.Name = dataReader["name"].ToString();
              

                categoryList.Add(category);
            }

            connection.Close();

            return categoryList;
        }
            

    }
}

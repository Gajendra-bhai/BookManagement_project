using BookManagement.DataAccess.Entity;
using BookManagement.DataAccess.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataAccess.Service
{
    public class CategoryRepository : ICategoryRepository
    {
        string connectionString = string.Empty;
        SqlConnection conn;
        SqlCommand cmd;

        public CategoryRepository()
        {
            connectionString = @"data source=LAPTOP-43NAK8J9\SQLEXPRESS;database=BookManagementDB;trusted_connection=true";
        }
        public bool Add(CategoryEntity entity)
        {
            //code to insert data in database
            try
            {
                int row = 0;
                using (conn = new SqlConnection(connectionString))
                {
                    cmd = new SqlCommand("spInsertBookCategory", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", entity.CategoryName);
                    cmd.Parameters.AddWithValue("@Discription", entity.Discription);
                    cmd.Parameters.AddWithValue("@IsActive", entity.IsActive);

                    conn.Open();
                    row = cmd.ExecuteNonQuery();
                    conn.Close();
                }

                if(row > 0)
                  return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public List<CategoryEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

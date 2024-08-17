using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookManagement.DataAccess.Entity;
using BookManagement.DataAccess.ServiceInterface;
using BookManagement.DataAccess.Service;


namespace BookManagement.BookModule
{
    public partial class BookCategory : System.Web.UI.Page
    {

        private readonly ICategoryRepository categoryRepository;
        public BookCategory()
        {
            categoryRepository = new CategoryRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CategoryEntity categoryEntity = new CategoryEntity()
            {
                CategoryName = txtCategoryName.Text,
                Discription = txtAreaCategoryDiscription.Text,
                IsActive = true
            };

            if (categoryRepository.Add(categoryEntity))
            {
                //Notify user that data save
                ClearForm();
            }
            else
            {
                //Notify User that data not saved
            }
        }

        private void ClearForm()
        {
            txtCategoryName.Text = string.Empty;
            txtAreaCategoryDiscription.Text = string.Empty;
        }

      
    }
}
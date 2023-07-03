using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "Select * From CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DiscriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DiscriptionTb.Value;
                   

                    string Query = "Insert into CategoryTbl values('{0}','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Inserted!!";
                    CatNameTb.Value = "";
                    DiscriptionTb.Value = "";
                    
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

       
        int Key = 0;
        protected void AuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoriesList.SelectedRow.Cells[2].Text;
            DiscriptionTb.Value = CategoriesList.SelectedRow.Cells[3].Text;
           
            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DiscriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DiscriptionTb.Value;
                    

                    string Query = "Update CategoryTbl set CatName ='{0}',CatDiscription='{1}' Where CatId={2}";
                    Query = string.Format(Query, CName, CDesc, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Updated!!";
                    CatNameTb.Value = "";
                    DiscriptionTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DiscriptionTb.Value == "")
                {
                    ErrMsg.Text = "Select an Category Data!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DiscriptionTb.Value;

                    string Query = "delete from CategoryTbl Where CatId = {0}";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Deleted!!";
                    CatNameTb.Value = "";
                    DiscriptionTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}
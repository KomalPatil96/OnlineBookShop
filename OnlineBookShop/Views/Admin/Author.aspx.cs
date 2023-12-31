﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Author : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowAuthor();
        }

        private void ShowAuthor()
        {
            string Query = "Select * From AuthorTbl";
            AuthorList.DataSource = Con.GetData(Query);
            AuthorList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(ANameTb.Value==""|| GenCb.SelectedIndex==-1 || CountryCb.SelectedIndex==-1)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "Insert into AuthorTbl values('{0}','{1}','{2}')";
                    Query = string.Format(Query, AName, Gender, Country);
                    Con.SetData(Query);
                    ShowAuthor();
                    ErrMsg.Text = "Author Inserted!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
        int Key = 0;
        protected void AuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ANameTb.Value = AuthorList.SelectedRow.Cells[2].Text;
            GenCb.SelectedValue = AuthorList.SelectedRow.Cells[3].Text;
            CountryCb.SelectedValue = AuthorList.SelectedRow.Cells[4].Text;
            if(ANameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AuthorList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "Update AuthorTbl set AutNamer ='{0}',AutGender='{1}',AutCountry='{2}' Where AutId={3}";
                    Query = string.Format(Query, AName, Gender, Country, AuthorList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthor();
                    ErrMsg.Text = "Author Updated!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
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
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select an Author Data!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "delete from AuthorTbl Where AutId = {0}";
                    Query = string.Format(Query, AuthorList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthor();
                    ErrMsg.Text = "Author Deleted!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}
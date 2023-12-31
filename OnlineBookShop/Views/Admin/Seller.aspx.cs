﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSeller();
        }
        private void ShowSeller()
        {
            string Query = "Select * From SellerTbl";
            SellerList.DataSource = Con.GetData(Query);
            SellerList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SAdd = AddressTb.Value;


                    string Query = "Insert into SellerTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, SName, SEmail, SPhone, SAdd);
                    Con.SetData(Query);
                    ShowSeller();
                    ErrMsg.Text = "Seller Inserted!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";

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
            SNameTb.Value = SellerList.SelectedRow.Cells[2].Text;
            EmailTb.Value = SellerList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = SellerList.SelectedRow.Cells[4].Text;
            AddressTb.Value = SellerList.SelectedRow.Cells[5].Text;

            if (SNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerList.SelectedRow.Cells[1].Text);
            }
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SAdd = AddressTb.Value;

                    string Query = "Update SellerTbl set SelName ='{0}',SelEmail='{1}',SelPhone='{2}',SelAddress='{3}' Where SelId={4}";
                    Query = string.Format(Query, SName, SEmail, SPhone, SAdd, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSeller();
                    ErrMsg.Text = "Seller Updated!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
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
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Select an Seller Data!!";
                }
                else
                {

                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SAdd = AddressTb.Value;

                    string Query = "delete from SellerTbl Where SelId = {0}";
                    Query = string.Format(Query, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSeller();
                    ErrMsg.Text = "Seller Deleted!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}
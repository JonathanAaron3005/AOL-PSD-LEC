using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Model;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Transactions
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        TransactionController trController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = (int)Session["ID"];
                List<Transaction> trHeaders = trController.getAllTransactionsById(id);
                trGridView.DataSource = trHeaders;
                trGridView.DataBind();
            }
        }

        protected void trGridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = trGridView.SelectedRow;
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/Views/Transactions/TransactionDetail.aspx?ID=" + id);
        }
    }
}
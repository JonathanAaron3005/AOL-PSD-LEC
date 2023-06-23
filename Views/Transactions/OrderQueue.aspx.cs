using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Controller;
using PSD_LEC.Model;

namespace PSD_LEC.Views.Transactions
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        TransactionController trController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Transaction> handledHeaders = trController.getHandledTransactions();
                List<Transaction> unhandledHeaders = trController.getUnhandledTransactions();
                trGridView.DataSource = unhandledHeaders;
                trGridView.DataBind();
                handledGridView.DataSource = handledHeaders;
                handledGridView.DataBind();
            }
        }

        protected void trGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int headerId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/Views/Transactions/TransactionDetail.aspx?ID=" + headerId);
            }
            if (e.CommandName == "Process")
            {
                int trId = Convert.ToInt32(e.CommandArgument);
                int staffid = Convert.ToInt32(Session["ID"]); //idstaff
                DateTime handleDate = DateTime.Now;

                Transaction header = trController.getTransactionById(trId);
                trController.handleTransaction(header, staffid, handleDate);

                //databind
                List<Transaction> handledHeaders = trController.getHandledTransactions();
                List<Transaction> unhandledHeaders = trController.getUnhandledTransactions();
                trGridView.DataSource = unhandledHeaders;
                trGridView.DataBind();
                handledGridView.DataSource = handledHeaders;
                handledGridView.DataBind();
            }
        }

        protected void handledGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int headerId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/Views/Transactions/TransactionDetail.aspx?ID=" + headerId);
            }
        }
    }
}
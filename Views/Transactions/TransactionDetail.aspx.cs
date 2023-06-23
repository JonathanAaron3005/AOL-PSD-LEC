using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Transactions
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        TransactionController trController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int trId = int.Parse(Request.QueryString["ID"]);
                TableRepeater.DataSource = trController.getDetailsJoin(trId);
                TableRepeater.DataBind();
            }
        }
    }
}
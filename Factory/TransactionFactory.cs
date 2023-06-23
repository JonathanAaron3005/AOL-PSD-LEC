using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;

namespace PSD_LEC.Factory
{
    public class TransactionFactory
    {
        public static Transaction createTransaction(int customerId, int staffId, DateTime date)
        {
            Transaction tr = new Transaction();
            tr.CustomerId = customerId;
            tr.StaffId = staffId;
            tr.Date = date;

            return tr;
        }

        public static TransactionDetail createTransactionDetail(int trId, int bookId, int quantity)
        {
            TransactionDetail detail = new TransactionDetail();
            detail.TransactionId = trId;
            detail.BookId = bookId;
            detail.Quantity = quantity;

            return detail;
        }
    }
}
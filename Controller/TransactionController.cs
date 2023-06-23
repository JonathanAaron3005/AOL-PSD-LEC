using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Model;
using PSD_LEC.Handler;

namespace PSD_LEC.Controller
{
    public class TransactionController
    {
        TransactionHandler transactionHandler = new TransactionHandler();

        public int createTransaction(int customerId, int staffId, DateTime date)
        { 
            return transactionHandler.createTransaction(customerId, staffId, date);
        }

        //ini function buat ambil smua transaksi
        public List<Transaction> getTransactions()
        {
            return transactionHandler.getTransactions();
        }

        public Transaction getTransactionById(int transactionId)
        {
            return transactionHandler.getTransactionById(transactionId);
        }

        //ini function buat ambil smua transaksi yang dibuat oleh member tertentu
        public List<Transaction> getAllTransactionsById(int memberId)
        {
            return transactionHandler.getAllTransactionsById(memberId);
        }

        //TRANSACTION DETAIL
        public List<TransactionDetail> getDetails(int transactionId)
        {
            return transactionHandler.getDetails(transactionId);
        }

        public void createDetail(int transactionId, int bookId, int Quantity)
        {
            transactionHandler.createDetail(transactionId, bookId, Quantity);
        }

        public void handleTransaction(Transaction tr, int staffId, DateTime handleDate)
        {
            transactionHandler.handleTransaction(tr, staffId, handleDate);
        }

        public List<Transaction> getUnhandledTransactions()
        {
            return transactionHandler.getUnhandledTransactions();
        }

        public List<Transaction> getHandledTransactions()
        {
            return transactionHandler.getHandledTransactions();
        }

        public dynamic getDetailsJoin(int headerId)
        {
            return transactionHandler.getDetailsJoin(headerId);
        }
    }
}
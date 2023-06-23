using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Repository;

namespace PSD_LEC.Handler
{
    public class TransactionHandler
    {
        TransactionRepository transactionRepository = new TransactionRepository();

        public int createTransaction(int customerId, int staffId, DateTime date)
        { 
            return transactionRepository.createTransaction(customerId, staffId, date);
        }

        //ini function buat ambil smua transaksi
        public List<Transaction> getTransactions()
        {
            return transactionRepository.getTransactions();
        }

        //ini function buat ambil smua transaksi yang dibuat oleh member tertentu
        public List<Transaction> getAllTransactionsById(int memberId)
        {
            return transactionRepository.getAllTransactionsById(memberId);
        }

        //TRANSACTION DETAIL
        public List<TransactionDetail> getDetails(int transactionId)
        {
            return transactionRepository.getDetails(transactionId);
        }

        public void createDetail(int transactionId, int bookId, int Quantity)
        {
            transactionRepository.createDetail(transactionId, bookId, Quantity);
        }

        public Transaction getTransactionById(int transactionId)
        {
            return transactionRepository.getTransactionById(transactionId);
        }

        public void handleTransaction(Transaction tr, int staffId, DateTime handleDate)
        {
            transactionRepository.handleTransaction(tr, staffId, handleDate);
        }

        public List<Transaction> getUnhandledTransactions()
        {
            return transactionRepository.getUnhandledTransactions();
        }

        public List<Transaction> getHandledTransactions()
        {
            return transactionRepository.getHandledTransactions();
        }

        public dynamic getDetailsJoin(int headerId)
        {
            return transactionRepository.getDetailsJoin(headerId);
        }
    }
}
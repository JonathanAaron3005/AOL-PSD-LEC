using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Factory;

namespace PSD_LEC.Repository
{
    public class TransactionRepository
    {
        Database1Entities1 db = new Database1Entities1();

        //TRANSACTION
        public int createTransaction(int customerId, int staffId, DateTime date)
        {
            Transaction tr = TransactionFactory.createTransaction(customerId, staffId, date);
            db.Transactions.Add(tr);
            db.SaveChanges();

            return tr.Id;
        }

        //ini function buat ambil smua transaksi
        public List<Transaction> getTransactions()
        {
            return db.Transactions.ToList();
        }

        //ini function buat ambil smua transaksi yang dibuat oleh member tertentu
        public List<Transaction> getAllTransactionsById(int memberId)
        {
            List<Transaction> trList = (from tr in db.Transactions
                                        where tr.User.Id == memberId
                                        select tr).ToList();
            return trList;
        }

        //TRANSACTION DETAIL
        public List<TransactionDetail> getDetails(int transactionId)
        {
            return db.TransactionDetails.Where(x => x.TransactionId == transactionId).ToList();
        }

        public void createDetail(int transactionId, int bookId, int Quantity)
        {
            TransactionDetail detail = TransactionFactory.createTransactionDetail(transactionId, bookId, Quantity);
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }

        public Transaction getTransactionById(int transactionId)
        {
            return db.Transactions.Find(transactionId);
        }

        public List<Transaction> getUnhandledTransactions()
        {
            List<Transaction> list = (from tr in db.Transactions 
                                      where tr.Date > DateTime.Now 
                                      select tr).ToList();
            return list;
        }

        public List<Transaction> getHandledTransactions()
        {
            List<Transaction> list = (from tr in db.Transactions 
                                      where tr.Date <= DateTime.Now 
                                      select tr).ToList();
            return list;
        }

        public void handleTransaction(Transaction tr, int staffId, DateTime handleDate)
        {
            tr.StaffId = staffId;
            tr.Date = handleDate;
            db.SaveChanges();
        }

        public dynamic getDetailsJoin(int headerId)
        {
            return db.TransactionDetails
                .Where(details => details.TransactionId == headerId)
                .Join(db.Books,
                    details => details.BookId,
                    book => book.Id,
                    (details, book) => new
                    {
                        HeaderId = details.TransactionId,
                        BookISBN = book.ISBN,
                        BookName = book.Name,
                        PublisherName = book.Publisher.Name, 
                        BookPrice = book.Price,
                        BookYear = book.Year,
                        Quantity = details.Quantity,
                    })
                .ToList();
        }
    }
}
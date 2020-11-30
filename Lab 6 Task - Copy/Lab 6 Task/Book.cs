﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task
{
    class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }
        public void AddBookCopy(int x)
        {
            bookCopy = bookCopy + x;
        }
        public Book()
        {
           
        }
        public Book (string bookName,string bookAuthor,string bookId,string bookType,int bookCopy)
        {
            this.bookName = bookName;
            this.BookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.BookCopy = bookCopy;
        }
          public void ShowInfo()
        {
            Console.WriteLine("Book Name :" + bookName);
            Console.WriteLine("Book Author:" + bookAuthor);
            Console.WriteLine("Book Id :" + bookId);
            Console.WriteLine("Book Type:" + bookType);
            Console.WriteLine("Book Copy:" + bookCopy);
        }





    }
}

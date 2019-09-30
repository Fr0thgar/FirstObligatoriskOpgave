using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library
{
    public class Book
    {

        private string _title; // Minimum 2 tegn
        private string _author;
        private int _pages; // Mellem 10 og 1000 tegn
        private string _isbn; // SKAL være 13 tegn

        public Book(string title, string author, int pages, string isbn)
        {
            _title = title;
            _author = author;
            _pages = pages;
            _isbn = isbn;
        }

        public Book()
        {
            
        }
        [MinLength(2)]
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }
        [MinLength(9), MaxLength(1001)]
        public int Pages
        {
            get => _pages;
            set => _pages = value;
        }
        [StringLength(13)]
        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }

        #region ValidationRegion
//
//        private bool isIsbnValid(string Isbn)
//        {
//            if (Isbn.Length == 13)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//
//        public bool isPagesValid(Book Pages)
//        { 
//            if (Pages >= 9 && Pages <= 1001)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//
//        private bool isTitleValid(string Title)
//        {
//            if (Title.Length >=2)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
        #endregion

    }
}

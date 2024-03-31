using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookManagementSystem
{
    internal class Book
    {
        private string _title;
        private string _author;
        private string _publisher;
        private int _availableCopies;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public int AvailableCopies
        {
            get { return _availableCopies; }
            private set
            {
                if (value >= 0)
                    _availableCopies = value;
                else
                    throw new ArgumentException("Available copies cannot be negative.");

            }


        }

        public Book(string title, string author, string publisher, int availableCopies)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            AvailableCopies = availableCopies;
        }

        
            }
        }
    }     }

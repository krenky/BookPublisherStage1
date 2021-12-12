using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace BookPublisherStage1
{
    public class Author
    {
        #region Fields
        private string _firstName;
        private string _phone;
        private LinkedList _books;
        #endregion
        #region Properties
        public string PFirstName { get => _firstName; set => _firstName = value; }
        public string PPhone { get => _phone; set => _phone = value; }
        public LinkedList Books { get => _books; set => _books = value; }
        #endregion
        #region Constructor/Destructor
        public Author(string FirstName, string Phone)
        {
            PFirstName = FirstName;
            PPhone = Phone;
        }
        ~Author() { }
        #endregion
        #region Methods
        public override string ToString()
        {
            return "Имя: " + _firstName + ", " + "Номер телефона: " + _phone + "Книги:" + Books.ToString();
        }
        #endregion
    }
}

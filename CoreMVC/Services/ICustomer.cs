using CoreMVC.Models;

namespace CoreMVC.Services
{
    
    
        public interface ICustomer
        {
            void AddBooks(Books book);

            bool Delete(int ID);
            List<Books> GetBooks();
        }
    
}

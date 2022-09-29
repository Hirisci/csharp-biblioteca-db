using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace csharp_biblioteca
{
    internal class Library
    {
        private const string ConnectionString = "Data Source=alan-pc;Initial Catalog=db-library;Integrated Security=True";
        public Library() { }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            string query =
                "SELECT * " +
                "FROM Book" +
                "WHERE book.Quantity >0";

            using var connection = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(query,connection);
            connection.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string code = reader.GetString(1);
                string title = reader.GetString(2);
                DateOnly releasedate = DateOnly.FromDateTime(reader.GetDateTime(3));
                DateOnly editionDate = DateOnly.FromDateTime(reader.GetDateTime(4));
                int quantity = reader.GetInt32(5);
                string sector = reader.GetString(6);
                int numPage = reader.GetInt32(7);

                books.Add(new Book(code, title, releasedate, editionDate, quantity, sector, numPage));
            }



            return books;
        }

        public string showStorage()
        {
            string s = "";
            foreach (Book book in GetBooks())
            {
                s += book.ToString()+"\n";
            }
            return s;
        }














    }
}

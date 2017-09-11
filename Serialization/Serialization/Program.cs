using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book book = new Book();
            book.Name = "Цветы для Элджернона";
            book.Author = "Дэниел Киз";
            book.Year = 1995;
            book.Price = 2005;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("book.bin", FileMode.OpenOrCreate))
            {
              formatter.Serialize(fs, book);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("book.bin", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя {0}\nАвтор{1}", newBook.Name, newBook.Author);
            }
            Console.ReadLine();



        }
    }
}

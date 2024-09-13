using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp19
{

    class Book
    {
        public string title;
        public string author;
        public int id;
        public bool isBorrowed;

        public Book(string title, string author, int id, bool isBorrowed)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.isBorrowed = isBorrowed;
        }

        public void BorrowBook()
        {
            Console.WriteLine($"Book with this {id} is borrowed.");
        }

        public void ReturnBook()
        {
            Console.WriteLine($"Book with this {id} is returned.");
        }
    }

    class Library
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            foreach(Book  book in books)
            {
                Console.WriteLine($"Title: {book.title} \\ Author: {book.author} \\ Id: {book.id} \\ IsBorrowed: {book.isBorrowed}");
            }
        }

        public void BorrowBookById(int id)
        {
            foreach (Book book in books)
            {
                if(book.id == id)
                {
                    if(book.isBorrowed == true)
                    {
                        Console.WriteLine("This book has already borrowed.");
                        return;
                    }
                    book.isBorrowed = true;
                    book.BorrowBook();
                    break;
                }
            }
        }

        public void ReturnBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    book.isBorrowed = false;
                    book.ReturnBook();
                    break;
                }
            }
        }
    }

class Student
    {
        public int id;
        public string name;
        public int age;
      
        public  List<int> grades = new List<int>();

        public Student(int id, string name, int age, List<int> grades)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.grades = grades;
        }
       public void AddGrade()
        {
        }
        public int GetAverageGrade()
        {
            int sum = 0;

         for(int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }

         return sum/grades.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {id} \\ Nmae: {name} \\ Age: {age} \\ AverageGrades: {GetAverageGrade()}");
        }

    }

    class University
    {
        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudents(Student student)
        {
            Console.WriteLine($"Id: {student.id} \\ Nmae: {student.name} \\ Age: {student.age} \\ AverageGrades: {student.GetAverageGrade()}");
        }

        public void FindStudentById(int id)
        {
            foreach (Student student in students)
            {
                if (student.id == id)
                {
                    Console.WriteLine($"Id: {student.id} \\ Nmae: {student.name} \\ Age: {student.age} \\ AverageGrades: {student.GetAverageGrade()}");
                }
            }
        }
    }

    class Product
    {
        public string name;
        public string category;
        public int productId;
        public int price;
        public int quantity;

        public Product(string name, string category, int productId, int price, int quantity)
        {
            this.name = name;
            this.category = category;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public void UpdateQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ProductId: {productId} \\ Name: {name} \\ Category: {category} \\ Price: {price} \\ Quantity: {quantity}");
        }

    }

    class Inventory
    {
        public List<Product> products = new List<Product>();
    }

   public  class BankAccount
    {
        public string accountHolderName;
        public string accountNumber;
        public int balance;

        public BankAccount(string accountHolderNmae, string accountNumber, int balance)
        {
            this.accountHolderName = accountHolderNmae;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            this.balance = amount;
        }

        public void WithDraw(int count)
        {
            this.balance -= count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"AccountHolderName: {accountHolderName} \\ AccountNumber: {accountNumber} \\ Balance: {balance}");
        }
    }

    class Bank
    {
        public int index;
        BankAccount[] bankAccount = new BankAccount[50000];

        public void AddCount(BankAccount account)
        {
                       
            bankAccount[index] = account;
            index++;
        }

        public void DisplayAccounts()
        {
            for(int i = 0;i < bankAccount.Length; i++)
            {
                bankAccount[i].DisplayInfo();
            }
        }

        public void FindAccountByNumber(string accountNumber)
            {
            for (int i = 0; i < bankAccount.Length; i++)
            {
                if (bankAccount[i].accountNumber == accountNumber)
                {
                    Console.WriteLine($"AccountHolderName: {bankAccount.accountHolderName} \\ AccountNumber: {bankAccount.accountNumber} \\ Balance: {bankAccount.balance}");
                }
            }
        }

        public void DepositToAccount(string accountNumber,int amount)
        {
            for (int i = 0; i < bankAccount.Length; i++)
            {
                if (bankAccount[i].accountNumber == accountNumber)
                {
                    if (amount != null)

                    {
                        bankAccount.Deposit(amount);
                    }
                }
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

using System.Text;

namespace AssignmentOne
{
    internal class Program
    {

        class Book
        {
            public int pages { get; set; }
            public string title { get; set; }

            public override string ToString()
            {

                return $"{pages}   {title}";
            }
        }
        static void Main(string[] args)
        {

            Book bk = new Book() { title = "bkOne", pages = 1 };

            // Q01
            //object obj = bk;
            //Console.WriteLine(obj);

            // Q02
            //Console.WriteLine(bk.GetType());
            //Console.WriteLine(bk.GetHashCode());
            //Console.WriteLine(bk.Equals(bk));

            // Q03
            /*int pages = "464";
            Syntax error */
            int pages = 464;

            // Q04
            /* try
             {
                 int num = 0;
                 int remindar = 10 / num;
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Cannot divide by zero");
             } */



            // Q05
            int pages1 = 300;
            double iPages = pages1;

            // Q06
            double price = 49.99;
            int ePages = (int)price;

            // Q07
            string pagesText = "464";
            int stCnvert = Convert.ToInt32(pagesText);

            // Q08
            string yearText = "2023";
            int year = int.Parse(yearText);


            // Q09
            string badText = "abc";
            if ( int.TryParse(pagesText, out int val))
            {
                Console.WriteLine(val);
            }
            else
            {
                Console.WriteLine("invalid number");
            }

            string strPages = pages.ToString();
            //Console.WriteLine(strPages.GetType());


            // Q10
            int copies = 100;

            object bx = copies;
            //Console.WriteLine(bx);

            int newVar = (int)bx;
            //Console.WriteLine(copies);
        }
    }
}

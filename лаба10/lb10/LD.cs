using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{
    internal class LD
    {
        public string lastname { get; set; }
        public double lenght { get; set; }
        public double veight { get; set; }
        public DateTime date { get; set; }
        public LD(string lastname, int lenght, double veight, DateTime date)
        {
            this.lastname = lastname;
            this.lenght = lenght;
            this.veight = veight;
            this.date = date;
        }
        public LD()
        {
            this.lastname = "NN";
            this.lenght = 0;
            this.veight = 0;
            this.date = DateTime.Now;
        }
        public override string ToString()
        {
            return "LastName:" + lastname + "; lenght:" + lenght + "; veight:" + veight + "; age:" + Age() + "\n";
        }
        public void input()
        {
            Console.WriteLine("LastName:");
            lastname = Console.ReadLine();
            Console.WriteLine("Lenght:");
            lenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veight:");
            veight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Date:");
            date = Convert.ToDateTime(Console.ReadLine());
        }
        public int Age()
        {
            int a = DateTime.Today.Year - date.Year;
            if (date.Month > DateTime.Today.Month ||
            (date.Month == DateTime.Today.Month && date.Day > DateTime.Today.Day))
                a--;
            return a;
        }
    }
}

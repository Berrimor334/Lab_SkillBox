using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._0
{
    struct Worker
    {
        public int Id { get; set; }
        public DateTime DateTimeAdd { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public double Rise { get; set; }
        public DateOnly DateBirthday { get; set; }
        public string Сountry { get; set; }


        public string Print()
        {
            return $"\nid:{Id} \nДата и время регистрации:{DateTimeAdd} \nФИО:{FIO} \nВозраст:{Age} \nРост:{Rise} \nДень рождения:{DateBirthday} \nМесто рождения:{Сountry}";
        }

        public Worker(int Id, DateTime DateTimeAdd, string FIO, int Age, double Rise, DateOnly DateBirthday, string Сountry)
        {
            this.Id = Id;
            this.DateTimeAdd = DateTimeAdd;
            this.FIO = FIO;
            this.Age = Age;
            this.Rise = Rise;
            this.DateBirthday = DateBirthday;
            this.Сountry = Сountry;
        }

        public Worker(int Id, string FIO, int Age, double Rise, string Сountry) :
            this(Id, DateTime.Now, FIO, Age, Rise, new DateOnly(2022, 1, 6), Сountry)
        {

        }
    }
}

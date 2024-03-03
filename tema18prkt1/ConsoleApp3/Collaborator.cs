using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    ///  скрытые поля, конструкторы без параметров и с параметрами
    ///  (имена некоторых полей должны совпадать с идентификаторами 
    ///  параметров), свойства, метод вывода полей и метод вычисления 
    ///  дохода по формуле: k*p, где k – повышающий коэффициент.
    /// </summary>
    internal class Collaborator
    { 
        /// <summary>
        /// скрытое поле имени
        /// </summary>
        string name;
        /// <summary>
        /// скрытое поле фамилии
        /// </summary>
        string surname;
        /// <summary>
        /// скрытое поле даты рождения
        /// </summary>
        DateTime date;
        /// <summary>
        /// скрытое поле минимальной зарплаты
        /// </summary>
        int p;




        /// <summary>
        /// Свойство  для доступа к полю имени
        /// </summary>
        public string Name {  get { return name; } set {  name = value; } }
        /// <summary>
        /// свойство для доступа к полю фамилия
        /// </summary>
        public string Surname { get {  return surname; } set {  surname = value; } }
        /// <summary>
        /// свойство для доступа к полю дата рождения
        /// </summary>
        public DateTime Date { get { return date; } set { date = value; } }
        /// <summary>
        /// свойство для доступа к полю минимальная зарплата
        /// </summary>
        public int P { get { return p; } set { p = value; } }





        /// <summary>
        ///  конструкторы без параметров
        /// </summary>
        public Collaborator() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя<param>
        /// <param name="surname">фамилия</param>
        /// <param name="date">дата рождения</param>
        /// <param name="p">минимальная зарплата</param>
        public Collaborator (string name,string surname, DateTime date, int p)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.p = p;
        }
        /// <summary>
        /// виртуальный Метод вычисления дохода по формуле k*p
        /// </summary>
        /// <returns>доход</returns>
        virtual public double
            Kof(double k)
        {
            //Console.WriteLine("Введите коэффициент=");
            //int k=int.Parse(Console.ReadLine());
            return k * p;
        }




        /// <summary>
        /// метод вывода полей
        /// </summary>
        virtual public void Print()
        {
            Console.WriteLine($"имя-{name},фамилия-{surname},дата рождения-{date},минимальная зарплата{p}");
        }










        
    }
}

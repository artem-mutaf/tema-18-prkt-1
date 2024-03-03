using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// потомок базовогоо класса сотрудник
    /// </summary>
    internal class Manager:Collaborator
    {
        /// <summary>
        /// скрытое поле
        /// </summary>
        double ton;

        /// <summary>
        /// свойство
        /// </summary>
        public double Ton {  get { return ton; } set {  ton = value; } }

        /// <summary>
        /// пустой конструктор
        /// </summary>
        public Manager() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="date"></param>
        /// <param name="p"></param>
        /// <param name="k"></param>
        public Manager(string name,string surname,DateTime date,int p,double k) : base(name,surname,date,p) 
        {
            this.ton = k;
        }







    }
}

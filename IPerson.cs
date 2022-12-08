using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /*
     * Создать интерфейс - человек.
     * Создать классы – девушка и парень. 
     * Классы должны включать конструкторы, функцию для формирования строки информации о человеке.
     * Определить функцию реакции человека на вновь увиденного другого человека.
     * Сравнение производить по фамилии.
     */
    internal interface IPerson : IComparable, ICloneable
    {
        string Gender { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        new int CompareTo(object obj);
        new object Clone();
    }
}

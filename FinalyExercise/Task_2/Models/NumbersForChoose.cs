using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    internal class NumbersForChoose
    {
        public delegate void NotifyDelegate(int number);
        public event NotifyDelegate? NumberEvent;

        public void DataIn()
        {
            Console.WriteLine();
            Console.Write("Введите значение (1-(А-Я) или 2-(Я-А)): ");
            int number;
            if ((int.TryParse(Console.ReadLine(),out number)==false)) throw new MyException("Неправильное значение. Попробуйте заново");
            if (number != 1 && number != 2) throw new MyException("Неправильное значение. Попробуйте заново");
            DataEntered(number);
        }
        

        protected virtual void DataEntered(int number)
        {
            NumberEvent?.Invoke(number);
        }
    }
}

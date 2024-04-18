using Task_2.Models;

namespace Task_2
{
    internal class Program
    {/*
    Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек. 
    Сортировка должна происходить при помощи события. Сортировка происходит при введении пользователем 
    либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
    Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally 
    с использованием собственного типа исключения.
      */
        static void ShowNumber(int number)
        {
            SurnameList surname = new SurnameList();
            surname.NotSortedList();
            List<string> list = surname.ShowList();
            switch (number)
            {
                case 1: surname.Sort1(list);
                    break;
                case 2: surname.Sort2(list);
                    break;
            }
        }
        

        static void Main(string[] args)
        {
            NumbersForChoose numbersForChoose = new NumbersForChoose();
            numbersForChoose.NumberEvent += ShowNumber;
  
            while (true)
            {
                try
                {
                    numbersForChoose.DataIn();
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}

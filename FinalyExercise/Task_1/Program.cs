using Task_1.Models;

namespace Task_1
{/*
    - Создайте свой тип исключения.
    - Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
    - В блоке catch выведите в консольном сообщении текст исключения.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] ArrayOfExceptions = new Exception[]
                {   new FileNotFoundException("Файл не существует"),
                    new NotImplementedException("Метод или операция не реализованы"), 
                    new DirectoryNotFoundException("Недопустимая часть пути к каталогу"), 
                    new DivideByZeroException("Знаменатель в операции деления равен нулю"), 
                    new MyException("Собственное исключение") 
                };
            

            foreach (Exception exception in ArrayOfExceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} - {DateTime.Now}");
                }
            }
            Console.ReadLine();
            
        }
    }
}

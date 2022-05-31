using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Собственное исключения");
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);
            exception.HelpLink = "www.google.ru";
        }
    }
}

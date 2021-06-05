using System;
using System.Diagnostics;
using Extension_Practice.Extensions;

namespace Extension_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           ExtensionTest();
           Console.ReadLine();
        }



        static void ExtensionTest()
        {
            Exception handledException = null;

            Func<object> function = () =>
            {
                Debug.Write("Extension Deniyoruz.");
                throw new ArgumentNullException();
            };


            //DELEGEYİ TRY-CATCH İÇERİSİNDE ÇALIŞTIR.
            //APPLICATION
            var result = function.ExecuteInTryCatch<ApplicationException>(ref handledException);

            if (result && handledException != null)
            {
                Debug.Write("Başka Bir Hata Oluştu.");
            }
        }
    }
}

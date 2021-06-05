using System;

namespace Extension_Practice.Extensions
{
    public static class FuncExtensions
    {
        public static bool ExecuteInTryCatch<TException>(this Func<object> function, ref Exception handledException) where TException : Exception
        {

            try
            {
                function();
                return true;
            }

            catch (Exception ex)
            {
                handledException = ex;  //KULLANICIYA HATAYI DÖNDÜR

                if (ex.GetType() == typeof(TException))
                    return false;

                //KULLANICININ BELİRTTİĞİ HATAYA TAKILMADI
                return true;

            }
        }
    }
}
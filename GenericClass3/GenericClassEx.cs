using System;
namespace GenericClass3
{
    public class GenericClassEx
    {
        public void GetData<T>(string typeChar, T value)
        {
            Console.WriteLine("{0} : {1}",  value, typeChar);
        }
    }
}

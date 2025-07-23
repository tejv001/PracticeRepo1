namespace GenericClassPractice
{
    public class GenericClass<T>
    {
        public T Field;
    }
    
    public class Greet
    {
        public T GreetMethod<T>(T field)
        {
            T message = field;
            return message;
        }
    }
}

namespace ListPractice
{
    public class GenericClass2<T>
    {
        private T _data;
        public T value { get
            {
                return _data;
            } 
            set
            {
                _data = value;
            } 
        }

    }
}

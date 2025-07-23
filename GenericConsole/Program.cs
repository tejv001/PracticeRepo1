using GenericClassPractice;
using ListPractice;
using System.Collections.ObjectModel;
using System.Collections;
class Program
{
    public static void Main(String [] args)
    {
        GenericClass<string> objCls1 = new GenericClass<string>();
        objCls1.Field = "Hello";
        Console.WriteLine(objCls1.Field);

        Greet greetObj1 = new Greet();
        string greeting1 = greetObj1.GreetMethod("Hello");
        Console.WriteLine(greeting1);

        //ListClass listObj1 = new ListClass();
        List<int> list1 = new List<int>();
        for (int i = 5; i <= 10; i++)
        {
            list1.Add(i);
        }
        foreach (int i in list1)
        {
            Console.WriteLine(i);
        }
        Queue<int> queue1 = new Queue<int>();
        queue1.Enqueue(5);
        queue1.Enqueue(10);
        int removedNum = queue1.Dequeue();
        foreach(int i in queue1)
        {
            Console.WriteLine(i);
        }

        Stack<string> stck1 = new Stack<string>();
        stck1.Push("Hello");
        stck1.Push("C#");
        stck1.Push("JavaScript");
        stck1.Push("HTML");
        while(stck1.Count > 0)
        {
            Console.WriteLine("Data : " + stck1.Pop());
        }
        HashSet<string> hashSet1 = new HashSet<string>();
        hashSet1.Add("Hello");
        hashSet1.Add("Hola");
        hashSet1.Add("Hello");
        hashSet1.Add("Konichiwa");
        hashSet1.Add("Bonjour");
        Console.WriteLine(hashSet1.Count);
        LinkedList<int> linkedList1 = new LinkedList<int>();
        linkedList1.AddLast(5);
        linkedList1.AddFirst(10);
        linkedList1.AddAfter(linkedList1.First, 15);
        Console.WriteLine(String.Join(", ", linkedList1));
        Collection<int> cl1 = new Collection<int>();
        for (int i =1;  i <= 10; i++)
        {
            cl1.Add(i);
        }
        Collection<int> csortedList1 = new Collection<int>();
        for (int i = 1; i <= 10; i++)
        {
            csortedList1.Add(i);
        }
        Collection<int> cl3 = cl1;
        Console.WriteLine(String.Join(", ", cl1));
        int[] sArr1 = new int[cl1.Count];
        cl1.CopyTo(sArr1, 0);
        Console.WriteLine(String.Join(", ", sArr1));

        Console.WriteLine(cl1.Equals(cl3));
        Console.WriteLine(cl1.GetType());
        GenericClass2<string> clsObj1 = new GenericClass2<string>();
        clsObj1.value = "Hello";
        Console.WriteLine(clsObj1.value);

        List<string> l1 = new List<string> { "Hello", "Hi", "How are you" };
        //l1.Remove("Hii");
        int[] numArr1 = {1, 2, 3};
        List<int> sortedList1 = new List<int>(numArr1);
        foreach(int num in sortedList1)
        {
            Console.WriteLine(num);
        }
        int[] numArr2 = { 3, 4, 5, 7, 6 };
        sortedList1.AddRange(numArr2);
        sortedList1.ForEach(num => Console.WriteLine(num));
        int countR = sortedList1.RemoveAll(n => n==1);
        sortedList1.ForEach(num => Console.WriteLine(num));
        sortedList1.Sort();
        sortedList1.ForEach(num => Console.Write(num + " "));
        SortedList sortedList2 = new SortedList();
        sortedList2.Add(1, "One");
        sortedList2.Add(2, "Two");
        sortedList2.Add(3, "Three");
        Console.WriteLine("Trying to remove");
        sortedList2.Remove(40);
        foreach(DictionaryEntry pair in sortedList2)
        {
            Console.WriteLine($"Key : {pair.Key}, value: {pair.Value}");
        }
        for(int i = 0; i<sortedList2.Count; i++)
        {
            Console.WriteLine("{0} : {1}", sortedList2.GetKey(i), sortedList2.GetByIndex(i));
        }

        HashSet<int> hashSet3 = new HashSet<int>() { 1,2,3,4,5,6};
        HashSet<int> hashSet4 = new HashSet<int>() { 1, 2, 5, 6, 7 };
        var ans = new HashSet<int>(hashSet3);
        ans.UnionWith(hashSet4);
        Console.WriteLine(String.Join(" ",ans));
        var IntSec = new HashSet<int>(hashSet3);
        IntSec.IntersectWith(hashSet4);
        var ExpW = new HashSet<int>(hashSet3);
        Console.WriteLine(String.Join(" ", IntSec));
        ExpW.ExceptWith(hashSet4);
        Console.WriteLine(String.Join(" ", ExpW));
        SortedSet<int> sortedSet1 = new SortedSet<int> (){ 2, 1, 5, 3, 4, 9, 7, 8 };
        sortedSet1.Add(6);
        Console.WriteLine(String.Join(" ", sortedSet1));
        sortedSet1.RemoveWhere(num => num%2==0);
        Console.WriteLine(String.Join(" ", sortedSet1));
        Dictionary<int, char> dictionary1 = new Dictionary<int, char>();
        char character = 'A';
        for (int i = 0; i < 26; i++)
        {
            dictionary1[i] = character;
            character++;
        }
        foreach (KeyValuePair<int, char> pair in dictionary1)
        {
            Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
        }
        SortedDictionary<int, string> sortedDict1 = new SortedDictionary<int, string>();
        sortedDict1.Add(1, "One");
        sortedDict1.Add(2, "Two");
        string OneNum;
        if (sortedDict1.TryGetValue(1, out OneNum))
        {
            Console.WriteLine(OneNum);
        }

        Hashtable hashTable1 = new Hashtable();
        hashTable1.Add(1, "Neji");
        hashTable1.Add(2, "Hinata");

    }
}
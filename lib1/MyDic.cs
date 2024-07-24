class  LinkedList<T1, T2> {
    public T1 key ;
    public T2 value;
    public LinkedList<T1, T2> next { get; set; }
    public LinkedList(T1 _key, T2 _value) {
        key = _key;
        value = _value;
        next = null;
    }
    public static bool IsEmpty(LinkedList<T1, T2> obj) {
        return obj == null || (EqualityComparer<T1>.Default.Equals(obj.key, default) && EqualityComparer<T2>.Default.Equals(obj.value, default));
    }
}
class MyDictionary<T1, T2> {


    static int arr_size = 10;
    LinkedList<T1, T2>[] arr = new LinkedList<T1, T2>[arr_size]; // here it will create refernces to null 
    public static int hash_function(T1 key) {
        int hash = key.GetHashCode()  & 0x7FFFFFFF;
        return hash;
    }
    public bool ContainsKey(T1 key)  {

        int hash = hash_function(key);
        int index = hash % arr_size;
        
        var current = arr[index];
        while (current != null && current.key.ToString() != key.ToString()) {
            current = current.next;
        }
        
        return current!=null &&  current.key.ToString() == key.ToString();
    }
    public T2 GetValue(T1 key)  {

        if (this.ContainsKey(key)) {
            int hash = hash_function(key);
            int index = hash % arr_size;
            
            var current = arr[index];
            while (current.key.ToString() != key.ToString()) {
                current = current.next;
            }
            return current.value;
        }
        else {
            throw new Exception("The key not found");
        }
    }
    unsafe public bool Add(T1 key, T2 value){

        LinkedList<T1, T2> obj = new LinkedList<T1, T2>(key = key,value = value){next = null};
        int hash = hash_function(key);
        int index = hash%arr_size;
        
        if (LinkedList<T1, T2>.IsEmpty(arr[index])) {
            arr[index] = obj;
        }
        else {
            LinkedList<T1, T2> head = arr[index];
            while (head.next != null) {
                head = head.next;
            }
            head.next = obj;
        }
        return false;
    }
    unsafe public void PrintArr() {
        Console.WriteLine("======");
        for (int i = 0; i < arr.Length; i++)
        {
            Print(arr[i]);
        }
    }
    unsafe public void Print(LinkedList<T1, T2> item) {
        
        var current = item;
        while (current != null)
        {
            Console.WriteLine($"{current.key} {current.value}");
            current = current.next;
        }
            
    }

}
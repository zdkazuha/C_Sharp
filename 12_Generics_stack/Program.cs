using _12_Generics_stack;

internal class Program
{
    private static void Main(string[] args)
    {
        //object[] test = {1,2.5,"test",true }; // boxing
        //foreach (object o in test)
        //{
        //    //Console.WriteLine((int)o + 1); // unboxing
        //    if(o is int)
        //        Console.WriteLine((int)o + 1);
        //    if (o is double)
        //        Console.WriteLine((double)o + 1);
        //    //if (o is bool)
        //    //    Console.WriteLine((int)o + 1);
        //}

        MyStack<int> stack = new MyStack<int>(10);
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.push(5);
        stack.push(6);

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.peek());
            stack.pop();

        }
    }
}
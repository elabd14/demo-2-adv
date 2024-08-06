namespace demo_2_advanced
{
    internal class Program
    {

       /* public static int sumlist(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];

            }
            return sum;

        }*/

        static void Main(string[] args)
        {
            #region genarics collection - lists 


            /*   List<int> Number = new List<int>();
               Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}"); 

               Number.Add( 1 );                Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
               Number.Add(2);
               Number.AddRange(new int[] {3,4});
               Number.Add(5);
               Console.WriteLine("after add 5th ");
               Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
               Number.TrimExcess(); 
               Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}"); 



                List <int> Number = new List<int>(5) { 1,2,3,4,5};
                 Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
                 Number.Add(6);
            
                 Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
               
                    {
                        Console.WriteLine(i);
                    }
                 Number[3] = 40;  
                 for (int i = 0; i < Number.Count; i++)
                 {
                     Console.WriteLine(Number[i]);
                 }

                 int result = sumlist(Number);
                 Console.WriteLine(result);*/


            #endregion


            #region list method 


               /*Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
                Number.Add(5);
                Number.Insert(5, 8);
                Number.InsertRange(4, new int[] { 1, 2});
                Number.BinarySearch(3);                 Number.Clear(); 
                Console.Write(Number.Contains(5));

             int[] array = new int[10];
               Number.CopyTo(array); 
               Number.CopyTo(array,3); 
               Number.CopyTo(2,array,5,3);

            List<int> Number = new List<int>(4) { 1, 2, 3, 4 };
              Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");
              Number.EnsureCapacity(4);
              Console.WriteLine($"count of list = {Number.Count} , capcity = {Number.Capacity}");*/
  


            #endregion

            #region  linkend list genaerics

                 /*     LinkedList<int> list = new LinkedList<int>();
                      list.AddFirst(1);
                      list.AddLast(3);
                      list.AddAfter(list.Find(1), 2);
                      list.AddBefore(list.Find(2), 3);  */ 
            #endregion


            #region stack 
          /*   Stack<int> stack = new Stack<int>();
             stack.Push(1);
             stack.Push(2);

             stack.Push(3);
             foreach (int i in stack) 
                 stack.Push(i);

             stack.Peek();
             stack.Pop();

             foreach (int i in stack)
                 stack.Push(i);*/
            #endregion

            #region 

          /*   Queue<int> list = new Queue<int>();
            object value = list.Enqueue(1);
             list.Enqueue(2);

             list.Enqueue(3);
             list.Enqueue(4);
             list.Peek();

             list.Dequeue();
             list.TryDequeue( out int element  );
             foreach (int i in list) 
                 list.Enqueue(i);*/
 
            #endregion
        }
    }
}
using System.Collections;

namespace CollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {   
            CustomArrayList customArrayList = new CustomArrayList(4);

            customArrayList.Add(1);
            customArrayList.Add(2);
            customArrayList.Add(3);

            customArrayList.Remove(3);
            customArrayList.RemoveAt(0);

            object[] objects = { "he", "hel", "hell", "hello" };

            customArrayList.AddRange(objects);

            Console.WriteLine( customArrayList[3]);
            foreach (object obj in customArrayList)
            {
                Console.WriteLine( obj );
            }
        }
    }
}
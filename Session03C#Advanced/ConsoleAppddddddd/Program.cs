
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppddddddd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ddd ");


            #region Hashtable - Non Generic
            //Hashtable ht = new Hashtable();
            //ht.Add("mohamed", 2211);
            //ht.Add("ali", 10);
            //ht.Add("saad", 011);
            //Console.WriteLine(ht.ContainsKey("mohamed"));//True
            //Console.WriteLine(ht.ContainsValue("021"));//False
            //Console.WriteLine(ht["mohamed"]);//2211

            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k);
            //}

            #endregion
            #region Dictionary - Generic
            //Dictionary<string , int > Note =new Dictionary<string , int>();
            //Note.Add("mohamed",12345678);
            //Note.Add("ali", 2004);
            //Console.WriteLine(  Note.TryAdd("mohamed",12345));//False
            ////Try To Get Value ===================================================================
            // //  Console.WriteLine(  Note["saad"]);
            ////Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key 'saad' was not present in the dictio
            ////The Best 
            //Note.TryGetValue("ali" , out int res);
            //Console.WriteLine(res);//2004

            //Note.TryGetValue("saad", out int res2); 
            //Console.WriteLine(res2);//o
            ////Count =====================================================================
            //Console.WriteLine(Note.Count);//2

            ////Search =====================================================================
            //Console.WriteLine( Note.ContainsKey("mohamed"));//True

            ////print Value From Key =====================================================================
            //Console.WriteLine(Note["mohamed"]);//12345678


            //// To print ===================================================================

            //foreach (KeyValuePair<string, int> key in Note)
            //{
            //    Console.WriteLine(key);
            //}
            ////foreach (KeyValuePair<string, int> key in Note)
            ////{
            ////    Console.WriteLine($"[({key.Key})  ({key.Value})]");
            ////}
            #endregion
            #region Sorted Dictionary -Generic
            //SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            //sortedDictionary.Add("mohamed", 123);
            //sortedDictionary.Add("ahmed", 456);
            //sortedDictionary.Add("Zezo", 789);

            //foreach (KeyValuePair<string, int> k in sortedDictionary)
            //{                           //[ahmed, 456]
            //                            //[mohamed, 123]
            //                            //[Zezo, 789]
            //    Console.WriteLine(k);

            //}

            ////foreach (var person in sortedDictionary)
            ////{
            ////    Console.WriteLine($"({person.Key}  -  {person.Value})");
            ////}

            ////TryAdd
            //Console.WriteLine(sortedDictionary.TryAdd("mohamed", 12));//False
            //                                                          //
            //Console.WriteLine(sortedDictionary.TryGetValue("saad", out int s) + " " + s); //False 0
            //Console.WriteLine(sortedDictionary.TryGetValue("d", out int d) +" "+d); //True  True 789
            ////sortedDictionary[Key]=>Value
            //Console.WriteLine(sortedDictionary["mohamed"]);//123   بس لو اتكتب مفتاح غير موجود يحدث خطا 

            #endregion
            #region Sorted List - Generic && Non Generic  مهم
            //// تخزن ال المفتاح والقيمه داخل 2 array 
            //SortedList<string , int> Note = new SortedList<string , int>();
            //Note.Add("ali",12);
            //Note.Add("saad", 112);
            //Note.Add("salwa", 1);
            //Note.Add("salma", 123);
            //Note.Add("said", 122);
            //Console.WriteLine("  ==  == ");
            //Console.WriteLine(Note.GetKeyAtIndex(0));//ali
            //Console.WriteLine(Note.GetValueAtIndex(0));//12
            //Console.WriteLine(Note.IndexOfKey("ali"));//0
            //Console.WriteLine(Note.IndexOfValue(12));//0
            //bool x = Note.TryAdd("salma",12);
            //Console.WriteLine(x);//False

            //Note.TryGetValue("ali", out int v);
            //Console.WriteLine(v);   //12

            //bool y =Note.ContainsKey("aaa");
            //Console.WriteLine(y);//False

            //Console.WriteLine(Note.Capacity);//8

            //Console.WriteLine(Note.Count);//5

            //foreach (var person in Note)
            //{
            //    Console.WriteLine($"{person.Key} : {person.Value}");
            //}

            #endregion
            #region HashSet - unique - Generic - unsorted
            //HashSet<string> set = new HashSet<string>();
            //set.Add("mohamed");
            //set.Add("mohamed");//لا يحسب
            //set.Add("ali");
            //Console.WriteLine(set.Count);//2

            //Console.WriteLine( set.Remove("d"));//False
            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region sortedset - unique - Generic - sortedمهم
        //SortedSet<int> ints = new SortedSet<int>(); 
        //    ints.Add(1);
        //    ints.Add(2);
        //    ints.Add(30);
        //    ints.Add(30);
        //    ints.Add(60);
        //    Console.WriteLine(ints.Count);//4 المكرر لا يخزن
        //    Console.WriteLine( ints.Average()); //23.25
        //    Console.WriteLine(ints.Min);//1
        //    Console.WriteLine(ints.Max);//60
        //    foreach (int i in ints)
        //    {
        //        Console.WriteLine(i);
        //    }
            #endregion  

        }
    }
}

using System;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection generic
            Dictionary<int,string> users=new Dictionary<int, string>();
            users.Add(1,"Ayşe Yılmaz");
            users.Add(2,"Ahmet Yılmaz");
            users.Add(3,"Emre Başpınar");
            users.Add(4,"Enes Başpınar");
            users.Add(514,"Deneme");

            // Dizinin Elemanlarına Erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(users[3]);
            foreach (var user in users)
                Console.WriteLine(user);
            //Count;
            Console.WriteLine("***** Count *****");
            Console.WriteLine(users.Count);
            
            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(users.ContainsKey(1));
            Console.WriteLine(users.ContainsValue("Emre Başpınar"));
            
            //Remove
            Console.WriteLine("***** Remove *****");
            users.Remove(514);
            foreach (var user in users)
                Console.WriteLine(user);
            
            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var user in users.Keys)
                Console.WriteLine(user);
            
            //Values
            Console.WriteLine("***** Values *****");
            foreach (var user in users.Values)
                Console.WriteLine(user);

        }
    }   
}
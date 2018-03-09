using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace JsonProject
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public new void ToString()
        {
            Console.WriteLine("id:{0},name:{1},age:{2},city:{3}",id,name,age,city);
        }
    }
    class JsonSerializer
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                id = 1,
                name = "jayasimha",
                age = 23,
                city = "bangalore"
            };
            Console.WriteLine("Serializing... ");
            Thread.Sleep(2000);
            string str = JsonConvert.SerializeObject(p);
            File.WriteAllText("F:\\Json1.json",str);
            Console.WriteLine("Json stored");

            Console.WriteLine("Deserializing...");
            //Thread.Sleep(2000);
            str = null;
            str = File.ReadAllText("F:\\Json1.json");
            //Person p1 = JsonConvert.DeserializeObject<Person>(str);
            //Console.WriteLine(p1);
            var dictionary = JsonConvert.DeserializeObject<IDictionary>(str);
            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            Console.Read();
        }
    }
}

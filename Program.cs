using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a Dictionary that contains information about several members of your family. Use the following example as a template.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Mackenzie"},
            {"age", "29"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Sharon"},
            {"age", "65"}
            });

            myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Mark"},
            {"age", "65"}
            });


        //Next, iterate over each item in myFamily and produce the following output.
            foreach (var famMember in myFamily)
            {
                Console.WriteLine($"{famMember.Value["name"]} is my {famMember.Key} and is {famMember.Value["age"]} years old");
            }
        }
    }
}

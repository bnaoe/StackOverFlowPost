using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StackOverFlowPost
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var isValidState = true;
            var stackPost = new StackPost("Encapsulation and access modifiers", DateTime.Now);
            stackPost.Description = "Learning encapsulation, encapsulating data and behavior around the data";
            

            while (isValidState)
            {
                Console.WriteLine("Type 'up' or 'down' to vote and 'exit' to exit");
                var input = Console.ReadLine();

                switch (stackPost.ValidateEntry(input))
                {
                    case "up": case "down": case "try":
                        break;

                    case "exit":
                        isValidState = false;
                        break;
                }

            }

            Console.WriteLine("Title: " + stackPost.Title);
            Console.WriteLine("Description: " + stackPost.Description);
            Console.WriteLine("Time Posted: " + stackPost.DateTimestamp);
            Console.WriteLine("No. of up votes: " + stackPost.GetUpVotes);
            Console.WriteLine("No. of down botes: " + stackPost.GetDownVotes);
            Console.WriteLine("Total no. of votes: " + stackPost.GetVotes);


        }


     
}
}

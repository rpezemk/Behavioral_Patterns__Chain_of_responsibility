using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibility
{
    class Chain_of_responsibility
    {
        static void Main(string[] args)
        {
            List<Problem> problems = new List<Problem>();
            problems.Add(new Problem() { Description = "easy", Complicacy = 2 });
            problems.Add(new Problem() { Description = "intermediate", Complicacy = 8 });
            problems.Add(new Problem() { Description = "hard", Complicacy = 87 });
            problems.Add(new Problem() { Description = "nightmare", Complicacy = 104 });


            Private Private = new Private();
            captain captain = new captain();
            Major major = new Major();

            Private.SetNext(captain).SetNext(major);

            Client client = new Client();

            foreach (Problem problem in problems)
            {
                client.ManageRequest(Private, problem);
            }
            Console.ReadLine();
        }
    }
}


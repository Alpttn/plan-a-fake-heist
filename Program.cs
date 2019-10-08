using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            //https://gist.github.com/askingalot/aa1877148da3f3fef98ddcd17410834e


            List<TeamMember> team = new List<TeamMember>(); //our list now contains teammembers class

            Console.Write("Bank Difficulty> ");
            int bankDifficulty = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //get the first team members name
            Console.Write("Name> ");
            string name = Console.ReadLine(); //must have name outside the loop


            //check to see if its empty, create the dictionary for new team member and add them to the team. prepare for another loop so we ask for another name
            while (name != "") //when no name is entered its false
            {
                Console.Write("Skill Level> ");
                string skillLevel = (Console.ReadLine());

                Console.Write("Courage factor> ");
                string courageFactor = (Console.ReadLine()); //returns a string and parse it into double parse and return a number

                TeamMember member = new TeamMember();
                member.Name = name;
                member.SkillLevel = int.Parse(skillLevel);
                member.CourageFactor = double.Parse(courageFactor);

                team.Add(member);

                //get the next team member's name
                Console.WriteLine();
                Console.Write("Name> ");
                name = Console.ReadLine();
            }

            Console.WriteLine();
            // Console.WriteLine($"Team Size: {team.Count}"); //count is the size. how many people on the team
            Console.WriteLine("Number of runs>");
            int trialRunCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //add up the skill level
            int teamSkill = 0; //keeps track of skill level outside the loop
            foreach (TeamMember member in team) //gives me access to each member one at a time
            {
                teamSkill += member.SkillLevel; //add to the existing skill varaiable of the entire team
            }

            HeistReport report = new HeistReport(); //constructor created the new report, if i wanted to add capabilities into this class then i'd need a class. this stores the successcount and failurecount

            for (int i = 0; i < trialRunCount; i++) //we wrapped code below in for loop. every time through the loop i'll get a new luckvalue and bank difficulty
            {
                Random generator = new Random(); //phase 4  gets random number
                int luckValue = generator.Next(-10, 11); //takes minval and maxvalue

                // int bankDifficulty = 100; //needed to bring this down from the top as well now we move it back up.
                int trialRunBankDifficulty = bankDifficulty += luckValue; //add luckvalue to bankdifficulty and set the value -- then set this to a variable.


                Console.WriteLine($"Team Skil level: {teamSkill}");
                Console.WriteLine($"Bank Difficulty: {trialRunBankDifficulty}");

                if (trialRunBankDifficulty > teamSkill) //did the team do better than the bank difficulty level?
                {
                    Console.WriteLine("Your heist failed :(");
                    report.FailureCount++; //add one to it, increment it
                }
                else
                {
                    Console.WriteLine("You are rich!"); //run it and see if you failed or not
                    report.SuccessCount++;
                }
            }
            //the report we are printing out. 
            report.Print();

            // Console.WriteLine();
            // Console.WriteLine("Heist results");
            // Console.WriteLine("-------------");
            // Console.WriteLine($"Successes: {report.SuccessCount}");
            // Console.WriteLine($"Failures: {report.FailureCount}");
            // Console.WriteLine();
            // Console.WriteLine();

            // foreach (Dictionary<string, string> member in team)
            // {
            //     Console.WriteLine("-----------");
            //     Console.WriteLine($"Name: {member["Name"]}");
            //     Console.WriteLine($"Skill: {member["SkillLevel"]}");
            //     Console.WriteLine($"Courage: {member["CourageFactor"]}");
            // }





        }
    }
}

using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");


            List<Dictionary<string, string>> team =
                new List<Dictionary<string, string>>();



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

                Dictionary<string, string> member = new Dictionary<string, string>() {
                    {"Name", name},
                    {"SkillLevel", skillLevel},
                    {"CourageFactor", courageFactor}
                };
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
            foreach (Dictionary<string, string> member in team) //gives me access to each member one at a time
            {
                string skillLevel = member["SkillLevel"]; //pull out the skill level
                teamSkill = teamSkill + int.Parse(skillLevel); //add to the existing skill varaiable of the entire team
            }

            for (int i = 0; i < trialRunCount; i++) //we wrapped code below in for loop. every time through the loop i'll get a new luckvalue and bank difficulty
            {
                Random generator = new Random(); //phase 4  gets random number
                int luckValue = generator.Next(-10, 11); //takes minval and maxvalue

                int bankDifficulty = 100; //needed to bring this down from the top as well.
                bankDifficulty += luckValue; //add luckvalue to bankdifficulty and set the value

                Console.WriteLine($"Team Skil level: {teamSkill}");
                Console.WriteLine($"Bank Difficulty: {bankDifficulty}");

                if (bankDifficulty > teamSkill) //did the team do better than the bank difficulty level?
                {
                    Console.WriteLine("Your heist failed :(");
                }
                else
                {
                    Console.WriteLine("You are rich!"); //run it and see if you failed or not
                }
            }











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

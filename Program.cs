using System;

namespace planyourheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");
            int bankDifficulty = 100;
            Random r = new Random();
            int luck = r.Next(-10, 10);

            bankDifficulty = bankDifficulty + luck;

            Team myTeam = new Team();

            while (true)
            {
                Console.Write("Enter your team member name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    Console.Write("Enter your team members skill level: ");
                    int skill = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter your team members courage factor (0.0 - 2.0): ");
                    double courage = Double.Parse(Console.ReadLine());

                    TeamMember criminal = new TeamMember()
                    {
                        Name = name,
                        Skill = skill,
                        Courage = courage
                    };

                    myTeam.AddTeamMember(criminal);

                    // Console.WriteLine($"{name.Name} has a skill level of {name.Skill} and a courage factor of {name.Courage}");
                }
            }

            Console.WriteLine($"You have {myTeam.Count} members in your team.");
            // myTeam.PrintTeam();
            int teamSkill = myTeam.SkillSum();

            Console.WriteLine($"Your team has a combined skill level of {teamSkill}, and the bank difficulty is set at {bankDifficulty}");

            if (teamSkill > bankDifficulty)
            {
                Console.WriteLine("You did it!");
            }
            else
            {
                Console.WriteLine("You failed!");
            }
        }
    }
}

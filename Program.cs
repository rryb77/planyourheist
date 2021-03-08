using System;

namespace planyourheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");

            Team myTeam = new Team();
            int bankDifficulty;
            Console.Write("Enter the bank difficulty: ");
            bankDifficulty = Int32.Parse(Console.ReadLine());

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

            int trialRuns;
            Console.Write("How many trial runs would you like to do? ");
            trialRuns = Int32.Parse(Console.ReadLine());

            int success = 0;
            int failed = 0;

            while (trialRuns > 0)
            {

                Random r = new Random();
                int luck = r.Next(-10, 10);
                bankDifficulty = bankDifficulty + luck;
                int teamSkill = myTeam.SkillSum();
                if (teamSkill > bankDifficulty)
                {
                    success++;
                }
                else
                {
                    failed++;
                }

                trialRuns--;
            }

            Console.WriteLine($"You succeeded {success} time(s) and failed {failed} time(s).");
        }
    }
}

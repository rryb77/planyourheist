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
            int bankDifficulty = 0;
            Console.Write("Enter the bank difficulty: ");

            while (true)
            {
                try
                {
                    bankDifficulty = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Please enter a valid number: ");
                }
            }





            while (true)
            {
                Console.Write("Enter your team member name: ");
                string name = Console.ReadLine();
                int skill = 0;
                double courage = 0.0;

                if (name == "")
                {
                    break;
                }
                else
                {
                    Console.Write("Enter your team members skill level: ");
                    while (true)
                    {
                        try
                        {
                            skill = Int32.Parse(Console.ReadLine());
                            if (skill >= 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter a positive number: ");
                                skill = Int32.Parse(Console.ReadLine());
                            }

                        }
                        catch
                        {
                            Console.Write("Please enter a positive number: ");
                        }
                    }

                    Console.Write("Enter your team members courage factor (0.0 - 2.0): ");

                    while (true)
                    {
                        try
                        {
                            courage = Double.Parse(Console.ReadLine());
                            if (courage >= 0 && courage <= 2.0)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter a number between 0.0 and 2.0: ");
                                skill = Int32.Parse(Console.ReadLine());
                            }
                        }
                        catch
                        {
                            Console.Write("Please enter a number between 0.0 and 2.0: ");
                        }
                    }

                    TeamMember criminal = new TeamMember()
                    {
                        Name = name,
                        Skill = skill,
                        Courage = courage
                    };

                    myTeam.AddTeamMember(criminal);
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

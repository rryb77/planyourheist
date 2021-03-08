using System;

namespace planyourheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");
            Console.Write("Enter your team member name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your team members skill level: ");
            int skill = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your team members courage factor (0.0 - 2.0): ");
            double courage = Double.Parse(Console.ReadLine());

            TeamMember numberOne = new TeamMember()
            {
                Name = name,
                Skill = skill,
                Courage = courage
            };

            Console.WriteLine($"{numberOne.Name} has a skill level of {numberOne.Skill} and a courage factor of {numberOne.Courage}");



        }
    }
}

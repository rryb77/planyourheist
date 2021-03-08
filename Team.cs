using System;
using System.Collections.Generic;

namespace planyourheist
{
    class Team
    {

        private Dictionary<string, TeamMember> _MyTeam { get; set; }
        public int Count
        {
            get
            {
                return _MyTeam.Count;
            }
        }

        public Team()
        {
            _MyTeam = new Dictionary<string, TeamMember>();
        }


        public void AddTeamMember(TeamMember criminal)
        {
            _MyTeam.Add(criminal.Name, criminal);
        }

        public void PrintTeam()
        {
            foreach (KeyValuePair<string, TeamMember> kvp in _MyTeam)
            {
                Console.WriteLine($"{kvp.Value.Name} has a skill level of {kvp.Value.Skill} and a courage factor of {kvp.Value.Courage} ");
            }
        }
        public int SkillSum()
        {
            int totalSkill = 0;
            foreach (KeyValuePair<string, TeamMember> kvp in _MyTeam)
            {
                totalSkill = totalSkill + kvp.Value.Skill;
            }
            return totalSkill;
        }
    }
}
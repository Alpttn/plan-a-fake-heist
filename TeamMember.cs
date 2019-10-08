namespace PlanYourHeist
{
    public class TeamMember
    {
        //if you don't make a constructor then c# will add a default one for you= defualt constructor. doesn't take any parameters
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor {get; set;}
    }
}
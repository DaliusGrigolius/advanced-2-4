namespace advanced_2_4
{
    public class SoccerTeam
    {
        private string Name { get; set; }

        public SoccerTeam(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"futbolo komandos pavadinimas: {Name}";
        }
    }
}

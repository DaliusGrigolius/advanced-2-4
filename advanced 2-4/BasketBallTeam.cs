namespace advanced_2_4
{
    public class BasketBallTeam
    {
        private string Name { get; set; }

        public BasketBallTeam(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"krepsinio komandos pavadinimas: {Name}";
        }
    }
}

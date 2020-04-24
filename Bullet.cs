namespace VideoGameDependencyInjectionDemo
{
    public class Bullet
    {
        public Bullet(string name, int gramsOfPowder)
        {
            Name = name;
            GramsOfPowder = gramsOfPowder;
        }

        public string Name { get; set; }
        public int GramsOfPowder { get; set; }

    }
}
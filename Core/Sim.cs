namespace Core
{
    public class Sim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Sim(int id, string name, int age, string sex)
        {
            Id = id;
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"Id: {Id}, {Name} — {Sex} ({Age} лет)";
        }
    }
}
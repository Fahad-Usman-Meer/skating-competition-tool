
namespace ClubCompFS
{
    public class Skater
    {
        public int Sequence { get; set; }
        public string Name { get; set; }

        public Skater(int sequence, string name)
        {
            Sequence = sequence;
            Name = name;
        }
    }
}

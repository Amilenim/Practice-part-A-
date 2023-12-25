using Project_A;

namespace Project_A.Classes
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public PaintingStyle PaintingStyle { get; set; }

        public Artist(int id, string name, int age, PaintingStyle paintingStyle)
        {
            throw new NotImplementedException();
        }
    }
}

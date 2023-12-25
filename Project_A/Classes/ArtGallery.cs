using Project_A;

namespace Project_A.Classes
{
    public class ArtGallery
    {
        public string Name { get; set; }
        public int Founded { get; set; }
        public Curator Curator { get; set; }
        public List<Painting> Paintings;

        public ArtGallery(string name, int founded, Curator curator)
        {
            throw new NotImplementedException();
        }
    }
}

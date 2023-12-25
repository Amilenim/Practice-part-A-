using Project_A;

namespace Project_A.Classes
{
    public class Painting : IPrintable
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Painting(Artist artist, string title, int year)
        {
            throw new NotImplementedException();
        }

        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}

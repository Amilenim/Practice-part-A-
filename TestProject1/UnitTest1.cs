using Project_A.Classes;
using Project_A;

namespace ArtGalleryClass.Tests
{
    [TestClass]
    public class ArtGalleryTests
    {
        [TestMethod]
        public void CreateArtist_ValidateProperties()
        {
            Artist artist = new Artist(1, "Pablo Picasso", 91, PaintingStyle.Cubism);

            Assert.AreEqual(1, artist.Id);
            Assert.AreEqual("Pablo Picasso", artist.Name);
            Assert.AreEqual(91, artist.Age);
            Assert.AreEqual(PaintingStyle.Cubism, artist.PaintingStyle);
        }

        [TestMethod]
        public void CreatePainting_ValidateProperties()
        {
            Artist artist1 = new Artist(1, "Leonardo da Vinci", 67, PaintingStyle.Realism);
            Painting painting = new Painting(artist1, "Mona Lisa", 1503);

            Assert.AreEqual(artist1, painting.Artist);
            Assert.AreEqual("Mona Lisa", painting.Title);
            Assert.AreEqual(1503, painting.Year);
        }

        [TestMethod]
        public void CreateArtGallery_ValidateProperties()
        {
            Curator curator = new Curator("Jane Doe", 40, 50000);
            ArtGallery artGallery = new ArtGallery("Modern Art Museum", 1950, curator);

            Assert.AreEqual("Modern Art Museum", artGallery.Name);
            Assert.AreEqual(1950, artGallery.Founded);
            Assert.AreEqual(curator, artGallery.Curator);
            Assert.IsNotNull(artGallery.Paintings);
            Assert.IsInstanceOfType(artGallery.Paintings, typeof(List<Painting>));
        }

        [TestMethod]
        public void PaintingImplementsIPrintable_InterfaceTest()
        {
            Painting painting1 = new Painting(new Artist(1, "Vincent van Gogh", 37, PaintingStyle.Expressionism), "Starry Night", 1889);

            Assert.IsTrue(painting1 is IPrintable);
        }
    }
}

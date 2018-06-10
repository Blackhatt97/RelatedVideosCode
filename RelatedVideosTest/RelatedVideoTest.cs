using RelatedVideos.Models;
using Xunit;

namespace RelatedVideosTest
{
    public class RelatedVideoTest
    {

        [Fact]
        public void CanCreateRelatedVideo()
        {
            // Arrange

            var vid4 = new Video
            {
                Name = "four",
                Id = "004",
                Category = { "action", "thriller", "comedy", "drama", }
            };
            var vid5 = new Video
            {
                Name = "four",
                Id = "005",
                Category = { "action", "thriller", "comedy", "drama", }
            };

            // Act

            var x = new RelatedVideo(vid4, vid5);

            // Assert

            Assert.Equal(250, x.Score);
        }
    }
}

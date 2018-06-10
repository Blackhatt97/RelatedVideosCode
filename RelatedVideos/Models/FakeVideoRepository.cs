namespace RelatedVideos.Models
{
    public class FakeVideoRepository
    {
        public static void LoadVideos(VideoStream stream)
        {

            stream.AddVideo(new Video
            {
                Id = "001",
                Name = "The Shawshank Redemption",
                Category = { "classic", "top 10 mivies", "sunday", "family" },
                Genre = { "crime", "drama", "police", },
                Actors = { "tim robbins", "morgan freeman", "bob gunton" }
            });
            stream.AddVideo(new Video
            {
                Id = "002",
                Name = "Forrest Gump",
                Category = { "classic", "top 10 mivies", "sunday", "family" },
                Genre = { "drama", "romance", "adventure" },
                Actors = { "tom hanks", "robin wright", "gary sinise" }
            });
            stream.AddVideo(new Video
            {
                Id = "003",
                Name = "Fight Club",
                Category = { "friends", "enthralling" },
                Genre = { "action", "mistery", "thriller" },
                Actors = { "brad pitt", "edward norton", "meat loaf"}
            });
            stream.AddVideo(new Video
            {
                Id = "004",
                Name = "Pulp Fiction",
                Category = { "classic", "top 10 mivies", "sunday", "family" },
                Genre = { "crime", "drama", "police" },
                Actors = { "john travolta", "uma thurman", "samuel l. jackson"}
            });
            stream.AddVideo(new Video
            {
                Id = "005",
                Name = "Inglorious Bastards",
                Category = { "mature", "friends", "pillow fight night", "top 10 mivies"},
                Genre = { "adventure", "war", "drama" },
                Actors = { "brad pitt", "diane kruger", "eli roth", "meat loaf"}
            });
            stream.AddVideo(new Video
            {
                Id = "006",
                Name = "The Wolf of Wallstreet",
                Category = { "amazing", "progressive", "inspired from real life events", "friends" },
                Genre = { "biography", "comedy", "crime" },
                Actors = { "leonard di caprio", "jonah hill", "margot robbie"}
            });
            stream.AddVideo(new Video
            {
                Id = "007",
                Name = "Catch me of you can",
                Category = { "amazing", "progressive", "inspired from real life events", "friends" },
                Genre = { "biography", "comedy", "crime" },
                Actors = { "leonard di caprio", "jonah hill", "margot robbie" }
            });
            stream.AddVideo(new Video
            {
                Id = "008",
                Name = "Saw",
                Category = {"night", "scary", "home alone" },
                Genre = { "horror"},
                Actors = { "carry elwes", "danny glover", "leigh whannell"}
            });
        }
    }
}

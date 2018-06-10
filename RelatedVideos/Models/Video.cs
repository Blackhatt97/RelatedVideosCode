using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelatedVideos.Models
{
    public class Video : IVideo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Category { get; set; } = new List<string>();
        public List<string> Genre { get; set; } = new List<string>();
        public List<string> Actors { get; set; } = new List<string>();

        public bool SameCategory(Video other)
        {
            return Category.SequenceEqual(other.Category);
        }

        public int SimilarCategory(Video other)
        {
            var length = Category.Count < other.Category.Count ? Category.Count : other.Category.Count;
            var similarVideos = 0;

            for (var i = 0; i < length; i++)
            {
                if (Category[i] != other.Category[i]) break;
                similarVideos++;
            }

            return similarVideos;
        }

        public int MixedCategory(Video other)
        {
            return Category.Intersect(other.Category).Count();
        }

        public bool SameGenre(Video other)
        {
            return Genre.SequenceEqual(other.Genre);
        }

        public int SimilarGenre(Video other)
        {
            var length = Genre.Count < other.Genre.Count ? Genre.Count : other.Genre.Count;
            var similarVideos = 0;

            for (var i = 0; i < length; i++)
            {
                if (Genre[i] != other.Genre[i]) break;
                similarVideos++;
            }

            return similarVideos;
        }

        public int MixedGenre(Video other)
        {
            return Genre.Intersect(other.Genre).Count();
        }

        public bool SameActor(Video other)
        {
            return Actors.SequenceEqual(other.Actors);
        }

        public int SimilarActor(Video other)
        {
            var length = Actors.Count < other.Actors.Count ? Actors.Count : other.Actors.Count;
            var similarVideos = 0;

            for (var i = 0; i < length; i++)
            {
                if (Actors[i] != other.Actors[i]) break;
                similarVideos++;
            }

            return similarVideos;
        }

        public int MixedActor(Video other)
        {
            return Actors.Intersect(other.Actors).Count();
        }

        public int CalculateScore(Video other)
        {
            var x = 0;

            if (SameCategory(other)) x += 100;
            else if (SimilarCategory(other) > 0) x += SimilarCategory(other) * 10;
            else if (MixedCategory(other) > 0) x += MixedCategory(other) * 5;

            if (SameGenre(other)) x += 100;
            else if (SimilarGenre(other) > 0) x += SimilarGenre(other) * 10;
            else if (MixedGenre(other) > 0) x += MixedGenre(other) * 5;

            if (SameActor(other)) x += 50;
            else if (SimilarActor(other) > 0) x += SimilarActor(other) * 5;
            else if (MixedActor(other) > 0) x += MixedActor(other) * 2;

            return x;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace RelatedVideos.Models
{
    public class Related
    {
        public List<RelatedVideo> RelatedVideosStream { get;}

        public Related(VideoStream stream, Video video)
        {
            RelatedVideosStream = new List<RelatedVideo>();
            foreach (var vid in stream.Stream)
            {
                if(vid.Id == video.Id || vid.CalculateScore(video) == 0) continue;
                RelatedVideosStream.Add(new RelatedVideo(vid, video));
            }

            //RelatedVideosStream.Sort(
            //    (x,y) => x.Score.CompareTo(y.Score));
            //RelatedVideosStream.Reverse();
            RelatedVideosStream = RelatedVideosStream.OrderByDescending(x => x.Score).ToList();
        }
    }
}

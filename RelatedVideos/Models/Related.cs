using System.Collections.Generic;
using System.Linq;
using RelatedVideos.Models.Interfaces;

namespace RelatedVideos.Models
{
    public class Related : IVideoStream
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

        public bool AddVideo(Video video)
        {
            return false;
        }

        public int RemoveVideo(Video video)
        {
            return RelatedVideosStream.RemoveAll(v => v.Video.Id == video.Id);
        }

        public int SizeOfStream()
        {
            return RelatedVideosStream.Count;
        }

        public bool ClearStream()
        {
            if (RelatedVideosStream.Count == 0) return false;

            RelatedVideosStream.Clear();
            return true;
        }
    }
}

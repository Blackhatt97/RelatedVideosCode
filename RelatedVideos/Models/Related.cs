using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RelatedVideos.Models
{
    public class Related : IVideoStream
    {
        public List<Video> RelatedVideosStream { get; set; } = new List<Video>();
        public int NumberOfRelatedVideos { get; set; }




        // **************************************************************************
        // IVideoStream Methods
        // **************************************************************************

            
        public bool AddVideo(Video video)
        {
            if (RelatedVideosStream.Any(v => v.Id == video.Id)) return false;

            RelatedVideosStream.Add(video);
            return true;
        }

        public int RemoveVideo(Video video)
        {
            return RelatedVideosStream.RemoveAll(v => v.Id == video.Id);
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

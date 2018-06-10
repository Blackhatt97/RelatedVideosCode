using System;
using System.Collections.Generic;
using System.Text;

namespace RelatedVideos.Models
{
    public class RelatedVideo
    {
        public Video Video { get; set; }
        public int Score { get;}

        public RelatedVideo(Video video, Video other)
        {
            Video = video;
            Score = Video.CalculateScore(other);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RelatedVideos.Models
{
    public interface IVideoStream
    {
        bool AddVideo(Video video);

        int RemoveVideo(Video video);

        int SizeOfStream();

        bool ClearStream();
    }
}

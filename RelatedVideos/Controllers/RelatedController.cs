using System;
using System.Collections.Generic;
using System.Text;
using RelatedVideos.Models;
using RelatedVideos.Views;

namespace RelatedVideos.Controllers
{
    public class RelatedController
    {


        public RelatedController()
        {

        }

        public int CreateStream(Video video, VideoStream videoStream)
        {
            var related = new Related(videoStream, video);
            ShowRelatedVideos.Show(related, video);

            return related.SizeOfStream();
        }

    }
}

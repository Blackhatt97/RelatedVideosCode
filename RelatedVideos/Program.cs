using System;
using RelatedVideos.Models;
using RelatedVideos.Views;

namespace RelatedVideos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stream = new VideoStream();
            FakeVideoRepository.LoadVideos(stream);
            foreach (var video in stream.Stream)
            {
                var related = new Related(stream, video);
                ShowRelatedVideos.Show(related, video);
            }
        }
    }
}

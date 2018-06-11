using System;
using RelatedVideos.Controllers;
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
                var rel = new RelatedController();
                var size = rel.CreateStream(video, stream);
                Console.WriteLine(size);
            } 


        }
    }
}

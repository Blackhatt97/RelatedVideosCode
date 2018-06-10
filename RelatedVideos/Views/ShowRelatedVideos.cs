using System;
using System.Collections.Generic;
using System.Text;
using RelatedVideos.Models;

namespace RelatedVideos.Views
{
    public class ShowRelatedVideos
    {
        public static void Show(Related stream, Video vid)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("==============================================");
            Console.WriteLine("Name: " + vid.Name);
            Console.WriteLine("Categories: ");
            PrintCriteria(vid.Category);
            Console.WriteLine("Genre: ");
            PrintCriteria(vid.Genre);
            Console.WriteLine("Actors: ");
            PrintCriteria(vid.Actors);
            Console.WriteLine("==============================================");
            Console.WriteLine("**********************************************");
            foreach (var video in stream.RelatedVideosStream)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Name: " + video.Video.Name);
                Console.WriteLine("Categories: ");
                PrintCriteria(video.Video.Category);
                Console.WriteLine("Genre: ");
                PrintCriteria(video.Video.Genre);
                Console.WriteLine("Actors: ");
                PrintCriteria(video.Video.Actors);
                Console.WriteLine("------------------------------------------");

            }
        }

        public static void PrintCriteria(List<string> criteria)
        {
            foreach (var element in criteria)
            {
                Console.Write(element + ", ");
                
            }
            Console.WriteLine("");
        }
    }
}

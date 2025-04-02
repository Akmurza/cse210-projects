using System;
using System.Collections.Generic;

namespace Proj;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");
            
            var video1Comments = new List<Comment>
            {
                new Comment("User1", "Great!"),
                new Comment("User2", "Thank you, great jump"),
                new Comment("User3", "Could you make continue?")
            };
            Video video1 = new Video("Jumping", "Jumper", 600, video1Comments);

            var video2Comments = new List<Comment>
            {
                new Comment("Son", "Nice content!!"),
                new Comment("Gray", "best info"),
                new Comment("John", "Best explanation ever "),
                new Comment("Sash", "Perfect!")
            };
            Video video2 = new Video("Scriptures explanation", "Man", 724, video2Comments);

            // 3 video
            var video3Comments = new List<Comment>
            {
                new Comment("Ivan gorilla", "It is wonderfull"),
                new Comment("Bob", "like it"),
                new Comment("Charlie Builder", "a bit fast for me")
            };
            Video video3 = new Video("Design Patterns", "Tech Samurai", 900, video3Comments);
            
            List<Video> videoList = new List<Video> { video1, video2, video3 };

            // to console
            foreach (var video in videoList)
            {
                 Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Duration: {video.GetDuration()} seconds");
                Console.WriteLine($"Comments ({video.GetNumberOfComments()}):");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.GetCommentAuthor()}: {comment.GetCommentText()}");
                }
                
                Console.WriteLine("\n+++++++++++\n");
            }
        }
    }

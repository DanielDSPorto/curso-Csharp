using System;
using System.Collections.Generic;
using section9_example2.Entities;

namespace section9_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();

            var post1Moment = DateTime.Parse("2019-03-27 10:06:00");
            var post2Moment = DateTime.Parse("2019-07-28 10:38:00");

            var title1 = "Just arrived, guys!";
            var title2 = "It's been 4 months now!";

            var Content1 = "City seems great so far";
            var Content2 = "Still liking it a lot";

            var likes1 = 27;
            var likes2 = 42;

            var Comment1Post1 = new Comment("Hope you like it!");
            var Comment2Post1 = new Comment("You MUST visit that cafe I've mentioned on our last conversation. I think you'll really like it");

            var Comment1Post2 = new Comment("Remind me again who told you this is the best city to live in?");
            var Comment2Post2 = new Comment("Yeah, but you still haven't visited me! We need to have a conversation ASAP. Really miss ya");

            posts.Add(new Post(post1Moment, title1, Content1, likes1));
            posts.Add(new Post(post2Moment, title2, Content2, likes2));

            posts[0].AddComment(Comment1Post1);
            posts[0].AddComment(Comment2Post1);
            posts[1].AddComment(Comment1Post2);
            posts[1].AddComment(Comment2Post2);

            foreach (Post post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace section9_example2.Entities
{
    public class Post
    { 

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment,string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
            
        }

        override public string ToString()
        {
            string finalString = $"{Title}\n {Likes} Likes - {Moment}\n{Content}\n";
            foreach(Comment comment in Comments)
            {
                finalString += $"{comment.Text}\n";
            }
            return finalString;
        }
    }
}

using System;
namespace section9_example2.Entities
{
    public class Comment
    {
        public Comment(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}    


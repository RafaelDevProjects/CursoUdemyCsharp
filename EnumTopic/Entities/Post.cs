using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumTopic.Entities
{
    internal class Post
    {
        private DateTime Moment { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }
        private int Likes { get; set; }
        private List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }
        public Post(string title, string content)
        {
            Moment = DateTime.Now;
            Title = title;
            Content = content;
        }

        public void PostLike()
        {
            Likes++;
        }

        public void PostComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public void GetComments()
        {
            foreach (var comment in Comments)
            {
                Console.WriteLine(comment);
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title)
            .Append(Likes)
            .Append(" Likes - ")
            .AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"))
            .AppendLine(Content)
            .AppendLine("Comments: ");

            foreach (var c in Comments)
            {
                sb.AppendLine(c.Text);   
            }
            return sb.ToString();
        }

    }
}

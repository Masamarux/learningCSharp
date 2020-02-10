using System;
using System.Text;
using System.Collections.Generic;

namespace PostComments.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(string title, string content, int likes)
        {
            Moment = DateTime.Now;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }

        /*public override string ToString()
        {
            string allComments = null;
            foreach (Comment c in Comments)
            {
                allComments += c + "\n";
            }

            return  Title + "\n"
                    + Likes + " Likes - " + Moment + "\n"
                    + Content + "\n"
                    + "Comments: \n"
                    + allComments;
        }*/
    }
}

using System;
using PostComments.Entities;

namespace PostComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string title1 = "Traveling to New Zealand";
            int likes1 = 12;
            string content1 = "I'm going to visit this wonderful country!";
            string comment11 = "Have a nice trip";
            string comment12 = "Wow that's awesome!";

            Post post1 = new Post(title1, content1, likes1);
            Comment com11 = new Comment(comment11);
            Comment com12 = new Comment(comment12);

            post1.addComment(com11);
            post1.addComment(com12);
            /////////////////////////////////////////////////////
            ///
            string title2 = "Good night guys";
            int likes2 = 5;
            string content2 = "See you tomorrow";
            string comment21 = "Good night";
            string comment22 = "May the Force be with you";

            Post post2 = new Post(title2, content2, likes2);
            Comment com21 = new Comment(comment21);
            Comment com22 = new Comment(comment22);

            post2.addComment(com21);
            post2.addComment(com22);

            Console.WriteLine(post1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(post2);
        }
    }
}

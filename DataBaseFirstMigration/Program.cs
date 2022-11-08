using System;

namespace DataBaseFirstMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            PostsDataBaseFirstEntities context = new PostsDataBaseFirstEntities();
            Post post = new Post
            {
                PostID = 1,
                DatePublished = DateTime.Now,
                Body = "Body",
                Title = "Title"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}

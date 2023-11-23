using Course.Entities;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("Have a nice Trip");
        Comment c2 = new Comment("wow that´s awesome");
        Comment c3 = new Comment("foda-se");
        Comment c4 = new Comment("wow");

        Post p1 = new Post(
            DateTime.Parse("21/06/2018 13:05:44"), 
            "traveling to new zeland",
            "estou indo visitar",
            12
            );

        p1.AddComment(c1);
        p1.AddComment(c2);

        Post p2 = new Post(
           DateTime.Parse("21/06/2018 13:05:44"),
           "traveling to new Brasil",
           "estou indo",
           11
           );

        p2.AddComment(c3);
        p2.AddComment(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
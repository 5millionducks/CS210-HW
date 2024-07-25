
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new("Python 101", "Douglas", 400);
        Video video2 = new("Coding for Dummies", "Clark", 1200);
        Video video3 = new("C# for Those of us Who Aren't Geniuses", "Tanner", 2200);
        Video video4 = new("Cake Decorating Relaxation ASMR", "Cakes4U2Day", 3400);

        video1.AddComment(new Comment("Coderbeginner", "This was so easy to follow!"));
        video1.AddComment(new Comment("ByronStrat", "What a great explanation."));
        video1.AddComment(new Comment("StrattyJr", "This could have been better, I guess it makes sense though."));

        video2.AddComment(new Comment("Coderbeginner", "I think I belong here."));
        video2.AddComment(new Comment("5ducks?", "I needed help with a project I was stuck on, thank you!!!"));
        video2.AddComment(new Comment("Strattyjr", "Could you explain more about the concepts here..."));

        video3.AddComment(new Comment("Coderbeginner", "I wish I were a genius, maybe this wouldn't be so hard."));
        video3.AddComment(new Comment("RaddleRiddle", "Nice"));
        video3.AddComment(new Comment("5ducks?", "Awesome job Tanner!"));

        video4.AddComment(new Comment("CakerLover48", "CAKE CAKE CAKE CAKE"));
        video4.AddComment(new Comment("hpluvr08", "Who else is procrastinating lol")); // not me, this is inspired by my sister... disclaimer...
        video4.AddComment(new Comment("user032467329528", "how are these people so good!"));

        List<Video> videos = [video1, video2, video3, video4];

        foreach (var video in videos)
        {
            Console.WriteLine(video);
        }
    }
}
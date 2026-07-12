using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROGRAM 1: YOUTUBE TRACKING ---");
        
        List<Video> videoList = new List<Video>();

        Video vid1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 600);
        vid1.AddComment(new Comment("Alice", "This made so much sense, thank you!"));
        vid1.AddComment(new Comment("Bob", "Great explanation of classes."));
        vid1.AddComment(new Comment("Charlie", "Are you going to make a part 2?"));
        videoList.Add(vid1);

        Video vid2 = new Video("Phone Review 2026", "TechSpecs", 945);
        vid2.AddComment(new Comment("Dave", "The camera quality looks incredible."));
        vid2.AddComment(new Comment("Eve", "Too expensive for me, sticking with my old phone."));
        vid2.AddComment(new Comment("Frank", "First! Great video."));
        videoList.Add(vid2);

        Video vid3 = new Video("How to Bake Sourdough", "ChefMilestone", 1230);
        vid3.AddComment(new Comment("Grace", "My crust turned out perfectly!"));
        vid3.AddComment(new Comment("Heidi", "Can I substitute the flour type?"));
        vid3.AddComment(new Comment("Ivan", "Clear and concise instructions."));
        videoList.Add(vid3);

        foreach (Video vid in videoList)
        {
            vid.DisplayVideoDetails();
        }
    }
}
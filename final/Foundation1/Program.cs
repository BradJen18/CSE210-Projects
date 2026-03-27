using System;

class Program
{
    static void Main(string[] args)
    {
        Comments comment1 = new Comments();
        comment1._name = "Joe";
        comment1._text = "This is the coolest video ever!";

        Comments comment2 = new Comments();
        comment2._name = "bob";
        comment2._text = "I've seen better";

        Comments comment3 = new Comments();
        comment3._name = "Darth";
        comment3._text = "Join the dark side. We have cookies!";

        Video video1 = new Video();
        video1._title = "Let the force be with you";
        video1._author = "Luke Skywalker";
        video1._length = 240;
        video1.comment.Add(comment1);
        video1.comment.Add(comment2);
        video1.comment.Add(comment3);
        video1.DisplayVideo();

        Comments comment4 = new Comments();
        comment4._name = "David";
        comment4._text = "I feel so educated!";

        Comments comment5 = new Comments();
        comment5._name = "Bob";
        comment5._text = "You're just ragebaiting us!!!";

        Comments comment6 = new Comments();
        comment6._name = "GamerDude192832";
        comment6._text = "I totally think that soup is a salad!!";

        Video video2 = new Video();
        video2._title = "Is soup a salad?";
        video2._author = "JimmyCeasar67";
        video2._length = 480;
        video2.comment.Add(comment4);
        video2.comment.Add(comment5);
        video2.comment.Add(comment6);
        video2.DisplayVideo();

        Comments comment7 = new Comments();
        comment7._name = "steve";
        comment7._text = "I tried following along and got lost so fast!";

        Comments comment8 = new Comments();
        comment8._name = "SirPranksALot";
        comment8._text = "This video is totally a fake. I saw the video cut to a complete Rubics cube!";

        Comments comment9 = new Comments();
        comment9._name = "BenevolentWinner64824";
        comment9._text = "This helped so much! I can finally solve a rubics cube!";

        Video video3 = new Video();
        video3._title = "Solving a Rubics cube in under a minute";
        video3._author = "BigBrains1234";
        video3._length = 60;
        video3.comment.Add(comment7);
        video3.comment.Add(comment8);
        video3.comment.Add(comment9);
        video3.DisplayVideo();
    }
}
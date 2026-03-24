using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignment
{
    class Song
    {
        public int Id;
        public string Title = "";
        public string Artist = "";
    }
    internal class LinkedListAssignment
    {
        static void Main()
        {
            LinkedList<Song> playlist = new LinkedList<Song>();

            var s1 = new Song { Id = 1, Title = "Song1", Artist = "A" };
            var s2 = new Song { Id = 2, Title = "Song2", Artist = "B" };
            var s3 = new Song { Id = 3, Title = "Song3", Artist = "C" };

            playlist.AddFirst(s1);
            playlist.AddLast(s2);
            playlist.AddAfter(playlist.First, s3);

            Console.WriteLine("Playlist Forward:");
            foreach (var s in playlist)
                Console.WriteLine(s.Title);

            Console.WriteLine("Playlist Backward:");
            var node = playlist.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value.Title);
                node = node.Previous;
            }

            playlist.Remove(s3);
            Console.WriteLine("After Removing Song3:");
            foreach (var s in playlist)
                Console.WriteLine(s.Title);

            Console.WriteLine("Play Next Feature:");
            node = playlist.First;
            while (node != null)
            {
                Console.WriteLine("Now Playing: " + node.Value.Title);
                node = node.Next;
            }
        }
    }
}

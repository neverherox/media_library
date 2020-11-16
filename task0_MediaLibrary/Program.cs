using System;
using System.Collections.Generic;
using task0_MediaLibrary.MediaFiles;
using task0_MediaLibrary.MediaPlayers;
using task0_MediaLibrary.PlayLists;
namespace task0_MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaLibrary mediaLibrary = new MediaLibrary();
            PlayList playList = new PlayList();
            playList.Add(new Video());
            playList.Add(new Audio());
            mediaLibrary.AddMediaFile(new Video());
            mediaLibrary.AddPlayList(playList);
            mediaLibrary.PlayAllPlayLists();
            Console.ReadKey();
        }
    }
}

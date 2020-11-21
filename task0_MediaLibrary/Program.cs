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
            MediaLibrary library = new MediaLibrary();
            IPlayList<Video> videoPlayList = new PlayList();
            IPlayList<Image> imagePlayList = new PlayList();
            IPlayList<Audio> audioPlayList = new PlayList();

            videoPlayList.Add(new Video());
            imagePlayList.Add(new Image());
            audioPlayList.Add(new Audio());

            library.AddPlayList((PlayList)audioPlayList);
            library.AddPlayList((PlayList)videoPlayList);
            library.AddPlayList((PlayList)imagePlayList);

            library.PlayAllPlayLists();
            Console.ReadKey();
        }
    }
}

using System.Collections.Generic;
using task0_MediaLibrary.MediaFiles;

namespace task0_MediaLibrary.PlayLists
{
    public class PlayList : IPlayList<MediaFile>
    {
        private List<MediaFile> mediaFiles;

        public string Name { get; set; }

        public List<MediaFile> MediaFiles { get { return mediaFiles; }  }

        public PlayList()
        {
            this.mediaFiles = new List<MediaFile>();
        }
        public void Add(MediaFile mediaFile)
        {
            mediaFiles.Add(mediaFile);
        }
        public void Delete(MediaFile mediaFile)
        {
            mediaFiles.Remove(mediaFile);
        }
    }
}

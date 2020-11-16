using System.Collections.Generic;
using task0_MediaLibrary.MediaFiles;
using task0_MediaLibrary.MediaPlayers;
using task0_MediaLibrary.PlayLists;

namespace task0_MediaLibrary
{
    public class MediaLibrary
    {
        private List<MediaFile> mediaFiles;
        private List<PlayList> playLists;
        private MediaPlayer mediaPlayer;

        public MediaLibrary()
        {
            mediaFiles = new List<MediaFile>();
            playLists = new List<PlayList>();
            mediaPlayer = new MediaPlayer();
        }
        public void AddMediaFile(MediaFile mediaFile)
        {
           mediaFiles.Add(mediaFile);
        }

        public void AddPlayList(PlayList playList)
        {
            playLists.Add(playList);
        }

        public void DeleteMediaFile(MediaFile mediaFile)
        {
            mediaFiles.Remove(mediaFile);
        }

        public void DeletePlayList(PlayList playList)
        {
            playLists.Remove(playList);
        }

        public void PlayFile(MediaFile mediaFile)
        {
            mediaPlayer.Play(mediaFile);
        }
        public void PlayPlayList(PlayList playList)
        {
            mediaPlayer.Play(playList);
        }
        public void PlayAllFiles()
        {
            for (int i = 0; i < mediaFiles.Count; i++)
            {
                mediaPlayer.Play(mediaFiles[i]);
            }
        }

        public void PlayAllPlayLists()
        {
            for (int i = 0; i < playLists.Count; i++)
            {
                mediaPlayer.Play(playLists[i]);
            }
        }
        public List<MediaFile> SearchInMediaFiles(string name)
        {
            List<MediaFile> foundFiles = new List<MediaFile>();
            foreach(MediaFile mediaFile in mediaFiles)
            {
                if (mediaFile.Name.Equals(name))
                {
                    foundFiles.Add(mediaFile);
                }
            }
            return foundFiles;
        }
        public List<PlayList> SearchInPlayLists(string name)
        {
            List<PlayList> foundPlayLists = new List<PlayList>();
            foreach (PlayList playList in playLists)
            {
                if (playList.Name.Equals(name))
                {
                    foundPlayLists.Add(playList);
                }
            }
            return foundPlayLists;
        }
    }
}

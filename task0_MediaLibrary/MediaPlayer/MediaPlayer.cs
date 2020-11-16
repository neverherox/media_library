using task0_MediaLibrary.MediaFiles;
using task0_MediaLibrary.PlayLists;

namespace task0_MediaLibrary.MediaPlayers
{
    public class MediaPlayer
    {
        public void Play(PlayList playList)
        {
            foreach(MediaFile mediaFile in playList.MediaFiles)
            {
                mediaFile.Play();
            }
        }
        public void Play(MediaFile mediaFile)
        {
            mediaFile.Play();
        }
            
    }
}

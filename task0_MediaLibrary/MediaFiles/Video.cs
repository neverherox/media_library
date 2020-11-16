using System;

namespace task0_MediaLibrary.MediaFiles
{
    public class Video : MediaFile
    {
        public double Duration { get; set; }

        public Video()
        {
            this.MediaType = MediaType.VideoType;
        }

        public override void Play()
        {
            Console.WriteLine("Video plays");
        }
    }
}

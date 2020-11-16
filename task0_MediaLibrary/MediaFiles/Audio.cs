using System;

namespace task0_MediaLibrary.MediaFiles
{
    public class Audio : MediaFile
    {
        public string Genre { get; set; }
        public string Author { get; set; }
        public double Duration { get; set; }
        public Audio()
        {
            this.MediaType = MediaType.AudioType;
        }

        public override void Play()
        {
            Console.WriteLine("Audio plays");
        }
    }
}

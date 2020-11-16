using System;

namespace task0_MediaLibrary.MediaFiles
{
    public class Image : MediaFile
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Image()
        {
            this.MediaType = MediaType.ImageType;
        }

        public override void Play()
        {
            Console.WriteLine("Image plays");
        }
    }
}

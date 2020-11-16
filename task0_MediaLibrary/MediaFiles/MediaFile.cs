namespace task0_MediaLibrary.MediaFiles
{
    public abstract class MediaFile
    {
        public string Name { get; set; }
        public double Size { get; set; }

        public MediaType MediaType { get; protected set; }
        public abstract void Play();
    }
}

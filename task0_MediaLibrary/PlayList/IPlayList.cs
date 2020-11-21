using task0_MediaLibrary.MediaFiles;

namespace task0_MediaLibrary
{
    public interface IPlayList<in T> where T : MediaFile
    {
        void Add(T t);
        void Delete(T t);
    }
}

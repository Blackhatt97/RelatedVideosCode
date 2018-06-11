namespace RelatedVideos.Models.Interfaces
{
    public interface IVideoStream
    {
        bool AddVideo(Video video);

        int RemoveVideo(Video video);

        int SizeOfStream();

        bool ClearStream();
    }
}

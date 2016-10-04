using MusicStore.DataAccess.Dtos;
using MusicStore.DataAccess.Dtos.Keys;

namespace MusicStore.DataAccess.GrainInterfaces
{
    public interface ISongGrain : ICrudGrain<Song, SongKey>
    {
    }
}

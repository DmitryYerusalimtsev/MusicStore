namespace MusicStore.DataAccess.Dtos.Prototypes
{
    public interface IDto<TKey>
    {
        TKey Key { get; set; }
    }
}

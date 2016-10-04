namespace MusicStore.DataAccess.Dtos.Prototypes
{
    public class BaseDto<TKey> : IDto<TKey>
    {
        public TKey Key { get; set; }
    }
}

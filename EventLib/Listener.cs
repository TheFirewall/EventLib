namespace NetCoreEvent
{
    public interface Listener
    {
        void AddThisListener(IEventManager manager)
        {
            manager.LoadEvents(this.GetType(), this);
        }
    }
}

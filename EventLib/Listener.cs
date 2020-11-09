namespace EventLib
{
    public interface Listener
    {
        void AddThisListener(EventManager manager)
        {
            manager.LoadEvents(this.GetType(), this);
        }
    }
}

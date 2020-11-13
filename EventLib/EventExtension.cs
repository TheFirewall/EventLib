namespace NetCoreEvent
{
    public static class EventExtension
    {
        public static bool OnCallEvent<T, C>(this T e, C calling) where T : MainEvent<T>
        {
            e.OnCallEvent(e, calling);
            return e.IsCancelled;
        }
        public static bool OnCallEvent<T>(this T e) where T : MainEvent<T>
        {
            e.OnCallEvent(e, e);
            return e.IsCancelled;
        }
    }
}

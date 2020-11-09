using System;
namespace EventLib
{
    public interface IEventManager
    {
        void LoadListener<T>(T evt);
        void LoadEvents<T>(Type type, T evt);
    }
}

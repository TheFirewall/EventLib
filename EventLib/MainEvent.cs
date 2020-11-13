using System;
using System.Diagnostics;

namespace NetCoreEvent
{

    public abstract class MainEventArgs : EventArgs, ICancellable
    {
        public bool IsCancelled { get; set; }
        public MainEventArgs()
        {
            IsCancelled = false;
        }

        public void SetCancelled(bool isCanceled)
        {
            IsCancelled = isCanceled;
        }
    }
    public abstract class MainEvent<T> : MainEventArgs
    {
        static public event EventHandler<T> EE;

        public MainEvent()
        {
            IsCancelled = false;
        }

        public void OnCallEvent<C>(T e, C calling)
        {
            EE?.Invoke(calling, e);
        }
    }
}

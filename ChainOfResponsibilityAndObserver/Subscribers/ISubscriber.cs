using ChainOfResponsibilityAndObserver.Events;

namespace ChainOfResponsibilityAndObserver.Subscribers
{
    internal interface ISubscriber
    {
        void pushButton(object obj, EventRequest e);
    }
}

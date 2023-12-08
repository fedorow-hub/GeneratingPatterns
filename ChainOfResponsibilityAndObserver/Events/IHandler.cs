namespace ChainOfResponsibilityAndObserver.Events
{
    internal interface IHandler
    {
        void setNext(IHandler next);
        void handle(EventRequest request);
    }
}

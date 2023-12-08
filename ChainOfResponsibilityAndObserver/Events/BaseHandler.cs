namespace ChainOfResponsibilityAndObserver.Events
{
    internal abstract class BaseHandler : IHandler
    {
        public IHandler nextHandler;
        public void setNext(IHandler next)
        {
            nextHandler = next;
        }

        public virtual void handle(EventRequest request)
        {
            if (nextHandler != null)
            {
                nextHandler.handle(request);
            }
        }
    }
}

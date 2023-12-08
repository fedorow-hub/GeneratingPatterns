using ChainOfResponsibilityAndObserver.Events;
using ChainOfResponsibilityAndObserver.Subscribers;

namespace ChainOfResponsibilityAndObserver.Widgets
{
    internal abstract class UIComponent : BaseHandler
    {
        public abstract bool draw(int line);
        public abstract int getHeight();
        public abstract int getWidth();

        private List<ISubscriber> listeners = new List<ISubscriber>();

        public void addSubscriber(ISubscriber s)
        {
            listeners.Add(s);
        }

        public void removeSubscriber(ISubscriber s)
        {
            listeners.Remove(s);
        }

        protected void notifySubscribers(EventRequest request)
        {
            foreach (ISubscriber s in listeners)
            {
                s.pushButton(this, request);
            }
        }

        public override void handle(EventRequest request)
        {
            if (request.isHandled()) return;

            Console.WriteLine($"Handle event in {this}");

            notifySubscribers(request);

            base.handle(request);
        }
    }
}

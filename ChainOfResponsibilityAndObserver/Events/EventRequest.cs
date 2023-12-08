namespace ChainOfResponsibilityAndObserver.Events
{
    internal class EventRequest
    {
        private bool handled = false;

	    public bool isHandled()
        {
            return handled;
        }

        public void setHandled(bool handled)
        {
            this.handled = handled;
        }
    }
}

using ChainOfResponsibilityAndObserver.Events;

namespace ChainOfResponsibilityAndObserver.Subscribers
{
    internal class ConcreteSubscriber : ISubscriber
    {
        public string Name { get; set; }
        public ConcreteSubscriber(string name)
        {
            Name = name;
        }
        public void pushButton(object obj, EventRequest e)
        {
            Console.WriteLine($"{Name} получил сообщение от {obj}");
        }
    }
}

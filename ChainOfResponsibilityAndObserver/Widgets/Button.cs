using ChainOfResponsibilityAndObserver.Events;

namespace ChainOfResponsibilityAndObserver.Widgets
{
    internal class Button : ContentControl
    {
        private char BUTTON_FRAME = '*';

        public Button(string text) : base(text) { }

        private void printBorder()
        {
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(BUTTON_FRAME);
            }
        }

        public override bool draw(int line)
        {
            if (line == 0 || line == 2)
            {
			    Console.Write(BUTTON_FRAME);
                printBorder();
                Console.Write(BUTTON_FRAME);
                return true;
            }
            if (line == 1)
            {
                Console.Write(BUTTON_FRAME);
                Console.Write(Text);
                Console.Write(BUTTON_FRAME);
                return true;
            }
            return false;
        }
        
        public override int getHeight()
        {
            return 3;
        }
        
        public override void handle(EventRequest request)
        {
            Console.WriteLine("Button pressed handled");
            //request.setHandled(true);
            base.handle(request);
        }

        public void press()
        {
		    Console.WriteLine("Button pressed");
            handle(new EventRequest());
        }
    }
}

namespace ChainOfResponsibilityAndObserver.Widgets
{
    internal class CompositControl : UIComponent
    {
        protected char COMPOSITE_FRAME = '+';

        protected List<UIComponent> children = new List<UIComponent>();

        public CompositControl add(UIComponent c)
        {
            children.Add(c);
            c.setNext(this);
            return this;
        }
        public void remove(UIComponent c)
        {
            children.Remove(c);
        }

        public void draw()
        {
            for (int i = 0; i < getHeight(); i++)
            {
                draw(i);
            }                
        }

        public List<UIComponent> getChildren()
        {
            return children;
        }
        private void printBorder()
        {
            for (int i = 0; i < getWidth() - 1; i++)
            {
                Console.Write(COMPOSITE_FRAME);
            }
        }

        public virtual void drawLineFinish()
        {
            Console.Write(COMPOSITE_FRAME);
        }

        public override bool draw(int line)
        {
            if(line == 0 || line == getHeight() - 1)
            {
                printBorder();
                drawLineFinish();
                return true;
            }
            if (line > 0 && line < getHeight() - 1)
            {
			    Console.Write(COMPOSITE_FRAME);
                foreach (UIComponent c in children)
                {
                    if (!c.draw(line - 1))
                    {
                        for (int i = 0; i < c.getWidth(); i++)
                        {
                            Console.Write(' ');
                        }
                    }                        
                }                    
                drawLineFinish();
                return true;
            }
            return false;
        }

        public override int getHeight()
        {
            int max = 0;
            foreach (UIComponent c in children)
            {
                if (c.getHeight() > max)
                {
                    max = c.getHeight();
                }                    
            }                
            return max + 2;
        }

        public override int getWidth()
        {
            int summa = 0;
            foreach (UIComponent c in children)
            {
                summa += c.getWidth();
            }               
            return summa + 2;
        }
    }
}



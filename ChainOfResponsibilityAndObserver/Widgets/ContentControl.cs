namespace ChainOfResponsibilityAndObserver.Widgets
{
    internal abstract class ContentControl : UIComponent
    {
        public string Text { get; set; }

        public ContentControl(string text)
        {
            Text = text;
        }

        public override int getWidth()
        {
            return Text.Length + 2;
        }
        
        public override int getHeight()
        {
            return 1;
        }
    }
}

namespace ChainOfResponsibilityAndObserver.Widgets
{
    internal class MainWindow : CompositControl
    {
        public override void drawLineFinish()
        {
            base.drawLineFinish();
            Console.WriteLine();
        }
    }
}

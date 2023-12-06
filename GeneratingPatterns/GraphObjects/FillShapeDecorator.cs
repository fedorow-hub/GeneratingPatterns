namespace GeneratingPatterns.GraphObjects
{
    internal class FillShapeDecorator : SimpleShape
    {
        private SimpleShape _shapeForDecorate;
        private string _fillColor;

        public FillShapeDecorator(SimpleShape shapeForDecorate, string fillColor)
        {
            _shapeForDecorate = shapeForDecorate;
            _fillColor = fillColor;
        }
        public override void Draw()
        {
            _shapeForDecorate.Draw();
            Console.WriteLine($"Фигура залита цветом: {_fillColor}");
        }
    }
}

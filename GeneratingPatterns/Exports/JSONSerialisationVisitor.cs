using GeneratingPatterns.GraphObjects;

namespace GeneratingPatterns.Exports
{
    internal class JSONSerialisationVisitor : IExportVisitor
    {
        public void exportGraphObject(Point p)
        {
            Console.Write($"{{X:{p.X}, Y:{p.Y}, Color:{p.Color}}}");
        }

        public void exportGraphObject(Line l)
        {
            Console.Write($"{{XStart:{l.XStart}, YStart:{l.YStart}, XEnd:{l.XEnd}, YEnd: {l.YEnd}, Color:{l.Color}}}");
        }

        public void exportGraphObject(Circle c)
        {
            Console.Write($"{{X:{c.X}, Y:{c.Y}, Radius: {c.Radius}, Color:{c.Color}}}");
        }

        public void exportGraphObject(Triangle t)
        {
            Console.Write($"{{XA:{t.XA}, YA:{t.YA}, XB:{t.XB}, YB: {t.YB}, XC:{t.XC}, YC:{t.YC}, Color:{t.Color}}}");
        }
    }

    internal class XMLSerialisationVisitor : IExportVisitor
    {
        public void exportGraphObject(Point p)
        {
            Console.WriteLine("  <point>");
            Console.WriteLine($"    <x>{p.X}</x>");
            Console.WriteLine($"    <y>{p.Y}</y>");
            Console.WriteLine($"    <color>{p.Color}</color>");
            Console.WriteLine("  </point>");
        }

        public void exportGraphObject(Line l)
        {
            Console.WriteLine("  <line>");
            Console.WriteLine($"    <xstart>{l.XStart}</xstart>");
            Console.WriteLine($"    <ystart>{l.YStart}</ystart>");
            Console.WriteLine($"    <xend>{l.XEnd}</xend>");
            Console.WriteLine($"    <yend>{l.YEnd}</yend>");
            Console.WriteLine($"    <color>{l.Color}</color>");
            Console.WriteLine("  </line>");
        }

        public void exportGraphObject(Circle c)
        {
            Console.WriteLine("  <circle>");
            Console.WriteLine($"    <x>{c.X}</x>");
            Console.WriteLine($"    <y>{c.Y}</y>");
            Console.WriteLine($"    <radius>{c.Radius}</radius>");
            Console.WriteLine($"    <color>{c.Color}</color>");
            Console.WriteLine("  </circle>");
        }

        public void exportGraphObject(Triangle t)
        {
            Console.WriteLine("  <triangle>");
            Console.WriteLine($"    <xa>{t.XA}</xa>");
            Console.WriteLine($"    <ya>{t.YA}</ya>");
            Console.WriteLine($"    <xb>{t.XB}</xb>");
            Console.WriteLine($"    <yb>{t.YB}</yb>");
            Console.WriteLine($"    <xc>{t.XC}</xc>");
            Console.WriteLine($"    <yc>{t.YC}</yc>");
            Console.WriteLine($"    <color>{t.Color}</color>");
            Console.WriteLine("  </triangle>");
        }
    }
}

using GeneratingPatterns;
using GeneratingPatterns.Builders;

//ColorObjectsFactory colorObjectsFactory = new ColorObjectsFactory();
//colorObjectsFactory.createPoint(4, 5, "red");
//colorObjectsFactory.createDefaultPoint();
//colorObjectsFactory.createLine(0, 0, 100, 100, "green");
//colorObjectsFactory.createCircle(4, 5, 8, "blue");

//BlackObjectFactory blackObjectFactory = new BlackObjectFactory();
//blackObjectFactory.createPoint(4, 5);
//blackObjectFactory.createDefaultPoint();
//blackObjectFactory.createLine(0, 0, 100, 100);
//blackObjectFactory.createCircle(4, 5, 8);

//Scene.Instance.Draw();

Director director = new Director(new BuildRealScene());

director.make(true);

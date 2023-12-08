using ChainOfResponsibilityAndObserver.Subscribers;
using ChainOfResponsibilityAndObserver.Widgets;

CompositControl mainWin = new MainWindow();
CompositControl frame1 = new CompositControl();
frame1.add(new Button("OK"));
mainWin.add(frame1);
CompositControl frame2 = new CompositControl();
frame2.addSubscriber(new ConcreteSubscriber("Подписчик рамки кнопки Print"));
Button printButton = new Button("Print");
printButton.addSubscriber(new ConcreteSubscriber("Телевизор"));

ISubscriber fridge = new ConcreteSubscriber("Холодильник");
printButton.addSubscriber(fridge);
frame2.add(printButton);
mainWin.add(frame2);

mainWin.draw();

printButton.press();

printButton.removeSubscriber(fridge);

printButton.press();

using MediatorPattern;

Console.WriteLine("***Mediator Pattern Demo***\n");
ConcreteMediator mediator = new ConcreteMediator();
Friend1 Amit = new Friend1(mediator, "Amit");
Friend2 Sohel = new Friend2(mediator, "Sohel");
Boss Raghu = new Boss(mediator, "Raghu");
//Registering participants
mediator.Register(Amit);
mediator.Register(Sohel);
mediator.Register(Raghu);
//Displaying the participant's list
mediator.DisplayDetails();
Console.WriteLine("Communication starts among participants...");
Amit.Send("Hi Sohel,can we discuss the mediator pattern?");
Sohel.Send("Hi Amit,Yup, we can discuss now.");
Raghu.Send("Please get back to work quickly.");
//An outsider/unknown person tries to participate
Unknown unknown = new Unknown(mediator, "Jack");
unknown.Send("Hello Guys..");
// Wait for user
Console.Read();
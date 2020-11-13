# EventLib

Improved events for easier implementation in the project.

## Usage


```c#
//Creating an event implementation

public class ConsoleEvent : MainEvent<ConsoleEvent>
{
    public string Message { get; set; }
    
    public ConsoleEvent(string message)
    {
        Message = message;
    }
}

//Creating an event listener

public class EventListener : Listener//Interface
{
    public EventListener(EventManager manager){
        ((Listener)this).AddThisListener(manager);
    }

    [Event(Type=typeof(ConsoleEvent))]
    public void OnConsole(object sender, ConsoleEvent e){
        Console.WriteLine(e.Message);
        e.SetCancelled(true);
    }
}

EventManager em = new EventManager();
EventListener el = new EventListener();
((Listener)el).AddThisListener(em);
//OR
EventListener el = new EventListener(em);

ConsoleEvent e = new ConsoleEvent("test");
if (e.OnCallEvent(this)){// calling OnConsole in EventListener
    //true is cancelled
    Console.WriteLine("");
}


```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License
[GNU AGPL 3](https://github.com/TheFirewall/EventLib/blob/master/LICENSE)

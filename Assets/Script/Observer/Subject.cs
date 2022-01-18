public enum Event
{
    StatusChange,
    Equipment,
    GetItem,
}

public class Subject
{
    ObserverPattern head = null;

    // 메시지를 받을 UI
    public void AddObserver(ObserverPattern ob)
    {
        ob.nextOb = head;
        head = ob;
    }

    // 더이상 메시지를 받지 않을 UI
    public void RemoveObserver(ObserverPattern ob)
    {
        if (head == ob)
        {
            head = ob.nextOb;
            ob.nextOb = null;
            return;
        }

        ObserverPattern current = head;
        while (current != null)
        {
            if (current.nextOb == ob)
            {
                current.nextOb = ob.nextOb;
                ob.nextOb = null;
                return;
            }
            current = current.nextOb;
        }
    }

    // 메시지 전달
    public void Message(Event type)
    {
        ObserverPattern ob = head;
        while (ob != null)
        {
            ob.Notify(type);
            ob = ob.nextOb;
        }
    }
}

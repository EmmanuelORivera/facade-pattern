public class Facade
{
    protected Subsystem1 _subsystem1;
    protected Subsystem2 _subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        this._subsystem1 = subsystem1;
        this._subsystem2 = subsystem2;
    }

    // The Facade's methods are convenient shortcuts to the sophisticated
    // functionality of the subsystems. However, clients get only to a 
    // fraction of a subsystem's capabilities.
    public string Operation()
    {
        string result = "Facade initializes subsystems:\n";
        result += this._subsystem1.operation1();
        result += this._subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += this._subsystem1.operationN();
        result += this._subsystem2.operationZ();
        return result;
    }
}


// The subsystem can accept requests either from the facade or client
// directly. In any case, to the Subsystem, the Facade is yet another
// client, and it's not part of the subsystem.
public class Subsystem1
{
    public string operation1()
    {
        return "Subsystem1: Ready! \n";
    }

    public string operationN()
    {
        return "Subsystem1: Go!\n";
    }
}

public class Subsystem2
{
    public string operation1()
    {
        return "Subsystem2: Get ready! \n";
    }

    public string operationZ()
    {
        return "Subsystem2: Fire!\n";
    }
}

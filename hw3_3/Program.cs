//task 2.2

using System.Security.Cryptography;

abstract class Worker
{
    private string _name;
    private string _position;
    private string _workDay;
    public Worker(string name, string position, string workDay)
    {
        _name = name;
        _position = position;   
        _workDay = workDay;
    }

    public void Call()
    {
        Console.WriteLine("Call");
    }
    public void WriteCode()
    {
        Console.WriteLine("Write code");
    }
    public void Relax()
    {
        Console.WriteLine("Relax");
    }

    public abstract void FillWorkDay();
}

class Developer : Worker 
{
    private string _pos = "Developer";
    Worker worker;

    Developer(string name, string position, string workDay) : base(name, position,workDay)
    {
        this._pos = position;
    }
    override public void FillWorkDay()
    {
        worker.WriteCode();
        worker.Call();
        worker.Relax();
        worker.WriteCode();
    }
}

class Manager : Worker 
{
    private string _pos = "Manager";
    private Random _rnd = new Random();

    Worker worker;

    Manager(string name, string position, string workDay) : base(name, position, workDay)
    {
        this._pos = position;
    }

    private void randCall(int a, int b)
    {
        for(int i = _rnd.Next(a, b); i > 0; i--)
        {
            worker.Call();
        }
    }

    public override void FillWorkDay()
    {
        randCall(1, 10);
        worker.Relax();
        randCall(1, 5);
    }
}

class Team
{
    public string[] _worker = {"Bob", };
    private string[] _workerPosition = {"Developer", };
    private string[] _workerDay = {"odd day", };
    private string _nameTeam;

    public Team(string name)
    {
        _nameTeam = name;
    }

    public void AddWorker(string NameWorker, string WorkerPos, string WorkerDay)
    {
        int i = _worker.Length + 1;
        _worker[i]         = NameWorker;
        _workerPosition[i] = WorkerPos;
        _workerDay[i]      = WorkerDay;
    }

    public void ShowInfo()
    {
        Console.WriteLine(_nameTeam);
        foreach(string worker in _worker)
        {
            Console.WriteLine(worker);
        }
    }

    public void ShowDetalInfo()
    {
        Console.WriteLine("\n" + _nameTeam);
        for(int i = 0; i < _worker.Length; i++)
        {
            string msg = _worker[i] + " - " + _workerPosition[i] + " - " + _workerDay[i];
            Console.WriteLine(msg);
        }
    }
}


class Program
{
    private static void Main(string[] args)
    {
        Team q = new Team("qTeam");

        q.AddWorker("Jim", "Deweloper", "Even day");
        q.AddWorker("Bob", "Deweloper", "odd day");

        q.ShowInfo();

        q.ShowDetalInfo();

    }
}
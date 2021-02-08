interface IAction
{
    void Move();
}
interface IRunAction : IAction
{
    void Run();
}
class BaseAction : IRunAction
{
    public void Move()
    {
        Console.WriteLine("Move");
    }
    public void Run()
    {
        Console.WriteLine("Run");
    }
}

class RunAction : IRunAction
{
    public void Move()
    {
        Console.WriteLine("I am running");
    }
}

interface IAction
{
    void Move();
}
interface IRunAction : IAction
{
    new void Move();
}

public interface IAction
{
    void Move();
}
internal interface IRunAction : IAction
{
    void Run();
}

internal interface IAction
{
    void Move();
}
public interface IRunAction : IAction   // ошибка IRunAction может быть только internal
{
    void Run();
}
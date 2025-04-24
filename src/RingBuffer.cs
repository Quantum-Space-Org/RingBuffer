namespace Quantum.RingBuffer;

public class RingBuffer<T>(string name)
{
    private int _capacity;
    private T _message;
    public string Name { get; } = name;
    public int Start { get; set; }
    public int End { get; set; }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
        End = _capacity - 1;
    }

    public void Commit(T message)
    {
        _message = message;
    }

    public T Read()
    {
        return _message;
    }
}
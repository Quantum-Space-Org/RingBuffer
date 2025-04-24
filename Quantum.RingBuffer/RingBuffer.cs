namespace Quantum.RingBuffer;

public class RingBuffer<T>
{
    private int _capacity;
    private T _message;
    public string Name { get; }
    public int Start { get; set; }
    public int End { get; set; }

    public RingBuffer(string name)
    {
        Name = name;
    }

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
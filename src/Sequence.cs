namespace Quantum.RingBuffer;

public class Sequence(int value)
{
    public int Value { get; } = value;

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        var that = (Sequence)obj;
        return this.Value == that.Value;
    }
}
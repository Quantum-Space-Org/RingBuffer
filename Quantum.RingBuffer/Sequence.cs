namespace Quantum.RingBuffer;

public class Sequence
{
    public int Value { get; }

    public Sequence(int value) => Value = value;

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        var that = (Sequence)obj;
        return this.Value == that.Value;
    }
}
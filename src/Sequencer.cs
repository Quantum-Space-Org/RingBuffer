namespace Quantum.RingBuffer;

public class Sequencer(int maxValue)
{
    private int _currentSequence;
    public int MaxValue { get; } = maxValue;

    public Sequence Next()
    {
        RoundCurrentSequenceIfItReachesTheEnd();
        return new Sequence(_currentSequence++);
    }

    private void RoundCurrentSequenceIfItReachesTheEnd()
    {
        if (_currentSequence == MaxValue)
            _currentSequence = 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        var that = (Sequencer)obj;
        return this.MaxValue == that.MaxValue;
    }
}
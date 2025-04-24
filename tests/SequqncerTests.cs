using FluentAssertions;

namespace Quantum.RingBuffer.Tests;

public class SequencerTests
{
    [Fact]
    public void createIntegerSequencer()
    {
        var sequencer = new Sequencer(maxValue: 10);
        sequencer.MaxValue.Should().Be(10);
    }

    [Fact]
    public void theFirstMoveShouldReturnZero()
    {
        var sequencer = new Sequencer(maxValue: 2);
        sequencer.Next().Should().Be(Sequence(0));
    }

    [Fact]
    public void afterTwoMovesShouldReturnOne()
    {
        var sequencer = new Sequencer(maxValue: 2);
        sequencer.Next().Should().Be(Sequence(0));
        sequencer.Next().Should().Be(Sequence(1));
    }

    [Fact]
    public void afterThreeMovesShouldReturnTwo()
    {
        var sequencer = new Sequencer(maxValue: 3);
        sequencer.Next().Should().Be(Sequence(0));
        sequencer.Next().Should().Be(Sequence(1));
        sequencer.Next().Should().Be(Sequence(2));
    }

    [Fact]
    public void afterRecivingTheEndITShouldReturnZero()
    {
        var sequencer = new Sequencer(maxValue: 3);
        sequencer.Next().Should().Be(Sequence(0));
        sequencer.Next().Should().Be(Sequence(1));
        sequencer.Next().Should().Be(Sequence(2));

        sequencer.Next().Should().Be(Sequence(0));
    }

    [Fact]
    public void testEquality()
    {
        new Sequencer(maxValue: 3)
            .Should()
            .Be(new Sequencer(maxValue: 3));
    }
    private static Sequence Sequence(int value) => new(value);
}
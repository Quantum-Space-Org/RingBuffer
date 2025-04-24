using FluentAssertions;

namespace Quantum.RingBuffer.Tests;

public class RingBufferTests
{
    [Fact]
    public void createEmptyRingBuffer()
    {
        var ringBuffer = new RingBuffer<string>(name: "myRB");

        ringBuffer.Start.Should().Be(0);
        ringBuffer.End.Should().Be(0);
    }

    [Fact]
    public void createSuccessfully()
    {
        var ringBuffer = new RingBuffer<string>(name: "myRB");
        ringBuffer.SetCapacity(1000);

        ringBuffer.Start.Should().Be(0);
        ringBuffer.End.Should().Be(999);

        ringBuffer.Commit("Hello");
        ringBuffer.Read()
            .Should()
            .BeEquivalentTo("Hello");

        ringBuffer.Commit("World");
        ringBuffer.Read()
            .Should()
            .BeEquivalentTo("World");
    }
}
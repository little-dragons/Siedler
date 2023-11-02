namespace Test;

using Lini.Miscellaneous;

public class LayeredValuePoolTest
{
    private LayeredValuePool<int> Pool { get; set; }

    [SetUp]
    public void Setup()
    {
        Pool = new();
    }

    [Test]
    public void Emptying()
    {
        const int count = 50;

        List<int> keys = new();

        for (int i = 0; i < count; i++)
            keys.Add(Pool.Retrieve());

        foreach (var k in keys)
            Pool.Return(k);

        Assert.That(Pool.Count, Is.EqualTo(0));
    }

    [Test]
    public void Access()
    {
        const int count = 50;

        List<int> keys = new();

        for (int i = 0; i < count; i++)
            keys.Add(Pool.Retrieve());

        foreach (var k in keys)
            Pool[k] = 1;

        Pool.DoForAll((ref int x) => Assert.That(x, Is.EqualTo(1)));
    }

    [Test]
    public void HoleBehavior()
    {
        const int count = 500;
        const int tries = 10;

        List<int> keys = new();

        for (int i = 0; i < tries; i++)
        {

            for (int j = 0; j < count; j++)
                keys.Add(Pool.Retrieve());

            for (int j = 0; j < count; i++)
            {
                switch (Random.Shared.Next(2))
                {
                    case 0:
                        keys.Add(Pool.Retrieve());
                        break;
                    case 1:
                        if (keys.Count == 0)
                            return;

                        int index = Random.Shared.Next(keys.Count);
                        Pool.Return(keys[index]);
                        keys.RemoveAt(index);
                        break;
                }
            }

            foreach (var k in keys)
                Pool.Return(k);

            Assert.That(Pool.Count, Is.EqualTo(0));

            keys.Clear();
            Pool.Clear();
        }
    }
}
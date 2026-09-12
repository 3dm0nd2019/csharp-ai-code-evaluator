using NUnit.Framework;

public class Challenge01Tests
{
    [Test]
    public void Level1_With99XP_ShouldNotLevelUp()
    {
        var player = new PlayerProgression();

        player.AddXP(99);

        Assert.AreEqual(1, player.Level);
        Assert.AreEqual(99, player.XP);
    }

    [Test]
    public void Level1_With100XP_ShouldReachLevel2()
    {
        var player = new PlayerProgression();

        player.AddXP(100);

        Assert.AreEqual(2, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void Level1_With101XP_ShouldPreserveLeftoverXP()
    {
        var player = new PlayerProgression();

        player.AddXP(101);

        Assert.AreEqual(2, player.Level);
        Assert.AreEqual(1, player.XP);
    }

    [Test]
    public void Level1_With250XP_ShouldReachLevel3()
    {
        var player = new PlayerProgression();

        player.AddXP(250);

        Assert.AreEqual(3, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void Level1_With450XP_ShouldReachLevel4()
    {
        var player = new PlayerProgression();

        player.AddXP(450);

        Assert.AreEqual(4, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void NegativeXP_ShouldNotReduceProgress()
    {
        var player = new PlayerProgression();

        player.AddXP(50);
        player.AddXP(-10);

        Assert.AreEqual(1, player.Level);
        Assert.AreEqual(50, player.XP);
    }
}

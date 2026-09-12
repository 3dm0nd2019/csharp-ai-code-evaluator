using NUnit.Framework;
using System;

public class Challenge01CandidateBTests
{
    [Test]
    public void Level1_With99XP_ShouldNotLevelUp()
    {
        var player = new PlayerProgressionB();

        player.AddXP(99);

        Assert.AreEqual(1, player.Level);
        Assert.AreEqual(99, player.XP);
    }

    [Test]
    public void Level1_With100XP_ShouldReachLevel2()
    {
        var player = new PlayerProgressionB();

        player.AddXP(100);

        Assert.AreEqual(2, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void Level1_With101XP_ShouldPreserveLeftoverXP()
    {
        var player = new PlayerProgressionB();

        player.AddXP(101);

        Assert.AreEqual(2, player.Level);
        Assert.AreEqual(1, player.XP);
    }

    [Test]
    public void Level1_With250XP_ShouldReachLevel3()
    {
        var player = new PlayerProgressionB();

        player.AddXP(250);

        Assert.AreEqual(3, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void Level1_With450XP_ShouldReachLevel4()
    {
        var player = new PlayerProgressionB();

        player.AddXP(450);

        Assert.AreEqual(4, player.Level);
        Assert.AreEqual(0, player.XP);
    }

    [Test]
    public void NegativeXP_ShouldThrowException()
    {
        var player = new PlayerProgressionB();

        Assert.Throws<ArgumentOutOfRangeException>(() => player.AddXP(-10));
    }
}

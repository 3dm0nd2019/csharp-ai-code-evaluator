using NUnit.Framework;
using System;

public class Challenge01ReferenceTests
{
    [Test]
    public void NewPlayer_ShouldStartAtLevel1WithZeroXP()
    {
        var player = new PlayerProgressionReference();

        Assert.That(player.Level, Is.EqualTo(1));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void Level1_With99XP_ShouldNotLevelUp()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(99);

        Assert.That(player.Level, Is.EqualTo(1));
        Assert.That(player.XP, Is.EqualTo(99));
    }

    [Test]
    public void Level1_With100XP_ShouldReachLevel2()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(100);

        Assert.That(player.Level, Is.EqualTo(2));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void Level1_With101XP_ShouldPreserveLeftoverXP()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(101);

        Assert.That(player.Level, Is.EqualTo(2));
        Assert.That(player.XP, Is.EqualTo(1));
    }

    [Test]
    public void Level1_With250XP_ShouldReachLevel3()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(250);

        Assert.That(player.Level, Is.EqualTo(3));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void Level1_With450XP_ShouldReachLevel4()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(450);

        Assert.That(player.Level, Is.EqualTo(4));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void Level1_With1000XP_ShouldReachLevel6()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(1000);

        Assert.That(player.Level, Is.EqualTo(6));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void NegativeXP_ShouldThrowException()
    {
        var player = new PlayerProgressionReference();

        Assert.That(
            () => player.AddXP(-10),
            Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    public void NegativeXP_ShouldNotChangeExistingProgress()
    {
        var player = new PlayerProgressionReference();

        player.AddXP(50);

        Assert.That(
            () => player.AddXP(-10),
            Throws.TypeOf<ArgumentOutOfRangeException>());

        Assert.That(player.Level, Is.EqualTo(1));
        Assert.That(player.XP, Is.EqualTo(50));
    }
}

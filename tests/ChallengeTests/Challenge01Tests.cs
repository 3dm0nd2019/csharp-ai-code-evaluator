using NUnit.Framework;

public class Challenge01CandidateATests
{
    [Test]
    public void Level1_With99XP_ShouldNotLevelUp()
    {
        var player = new PlayerProgression();

        player.AddXP(99);

        Assert.That(player.Level, Is.EqualTo(1));
        Assert.That(player.XP, Is.EqualTo(99));
    }

    [Test]
    public void Level1_With100XP_ShouldReachLevel2()
    {
        var player = new PlayerProgression();

        player.AddXP(100);

        Assert.That(player.Level, Is.EqualTo(2));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    public void Level1_With101XP_ShouldPreserveLeftoverXP()
    {
        var player = new PlayerProgression();

        player.AddXP(101);

        Assert.That(player.Level, Is.EqualTo(2));
        Assert.That(player.XP, Is.EqualTo(1));
    }

    [Test]
    public void NegativeXP_ShouldNotReduceProgress()
    {
        var player = new PlayerProgression();

        player.AddXP(50);
        player.AddXP(-10);

        Assert.That(player.Level, Is.EqualTo(1));
        Assert.That(player.XP, Is.EqualTo(50));
    }

    [Test]
    [Explicit("Defect reproduction: Candidate A cannot process multiple level-ups.")]
    public void Level1_With250XP_ShouldReachLevel3()
    {
        var player = new PlayerProgression();

        player.AddXP(250);

        Assert.That(player.Level, Is.EqualTo(3));
        Assert.That(player.XP, Is.EqualTo(0));
    }

    [Test]
    [Explicit("Defect reproduction: Candidate A cannot process multiple level-ups.")]
    public void Level1_With450XP_ShouldReachLevel4()
    {
        var player = new PlayerProgression();

        player.AddXP(450);

        Assert.That(player.Level, Is.EqualTo(4));
        Assert.That(player.XP, Is.EqualTo(0));
    }
}

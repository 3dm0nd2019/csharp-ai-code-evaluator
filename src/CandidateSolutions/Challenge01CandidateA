public class PlayerProgression
{
    public int Level { get; private set; } = 1;
    public int XP { get; private set; } = 0;

    public void AddXP(int amount)
    {
        if (amount < 0)
            return;

        XP += amount;

        int requiredXP = 100 + ((Level - 1) * 50);

        if (XP >= requiredXP)
        {
            XP -= requiredXP;
            Level++;
        }
    }
}

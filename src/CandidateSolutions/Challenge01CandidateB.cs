using System;
public class PlayerProgressionB
{
    public int Level { get; private set; } = 1;
    public int XP { get; private set; } = 0;

    public void AddXP(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount));

        XP += amount;

        while (XP >= GetRequiredXP())
        {
            XP -= GetRequiredXP();
            Level++;
        }
    }

    private int GetRequiredXP()
    {
        return 100 + ((Level - 1) * 50);
    }
}

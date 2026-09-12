using System;

public class PlayerProgressionReference
{
    private const int BaseXPRequirement = 100;
    private const int XPIncreasePerLevel = 50;

    public int Level { get; private set; } = 1;
    public int XP { get; private set; } = 0;

    public void AddXP(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "XP amount cannot be negative.");
        }

        XP += amount;

        while (true)
        {
            int requiredXP = GetRequiredXP();

            if (XP < requiredXP)
                break;

            XP -= requiredXP;
            Level++;
        }
    }

    private int GetRequiredXP()
    {
        return BaseXPRequirement + ((Level - 1) * XPIncreasePerLevel);
    }
}

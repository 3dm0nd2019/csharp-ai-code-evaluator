# Challenge 01 Evaluation Report

## Challenge
Player XP and Level Progression

## Summary

Candidate B is the stronger implementation because it correctly supports multiple level-ups from a single XP award and explicitly rejects invalid negative XP values.

Candidate A works for simple progression cases but fails when one XP award is large enough to trigger more than one level-up.

## Candidate A Evaluation

### Strengths
- Starts at Level 1 with 0 XP.
- Correctly handles XP values below the level-up threshold.
- Correctly levels up when the threshold is reached.
- Preserves leftover XP after a single level-up.
- Prevents negative XP from reducing player progress.

### Weaknesses
Candidate A uses a single `if` statement when checking whether the player has enough XP to level up.

Because of this, the player can only gain one level per call to `AddXP()`.

For example, if the player receives 250 XP at Level 1:

- 100 XP is used to reach Level 2.
- 150 XP remains.
- The implementation stops checking.
- The player incorrectly remains at Level 2 with 150 XP.

The correct result should be Level 3 with 0 XP.

### Evaluation Outcome
**NEEDS REVISION**

## Candidate B Evaluation

### Strengths
- Correctly handles standard level progression.
- Preserves leftover XP.
- Supports multiple level-ups from a single XP award.
- Recalculates the required XP after each level increase.
- Explicitly rejects negative XP values using an exception.
- Is easy to test and understand.

### Potential Improvement
`GetRequiredXP()` is called twice during each loop iteration.

This is not a significant performance issue in this example, but storing the value in a local variable could improve readability and avoid repeated calculation.

### Evaluation Outcome
**PASS**

## Important Test Cases

| XP Award | Expected Level | Expected XP |
|---|---:|---:|
| 0 | 1 | 0 |
| 99 | 1 | 99 |
| 100 | 2 | 0 |
| 101 | 2 | 1 |
| 249 | 2 | 149 |
| 250 | 3 | 0 |
| 450 | 4 | 0 |

Negative XP should be rejected without reducing the player's current level or XP.

## Final Decision

Candidate B better satisfies the requirements.

The main reason is that Candidate B uses a loop to continue processing level-ups until the remaining XP is below the requirement for the next level.

Candidate A should replace its single level-up check with repeated progression logic in order to satisfy the multiple-level-up requirement.

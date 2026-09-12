# Challenge 01: Player XP and Level Progression

## Objective

Evaluate two C# implementations of a player progression system and determine which implementation is more correct, robust, and maintainable.

## Requirements

The system must:

1. Start the player at Level 1 with 0 XP.
2. Require 100 XP to advance from Level 1 to Level 2.
3. Increase the XP requirement by 50 XP for each new level.
4. Preserve leftover XP after a level-up.
5. Allow a single XP award to trigger multiple level-ups.
6. Reject negative XP values.
7. Never reduce the player's current level.
8. Keep the implementation clear and testable.

## Example

A Level 1 player receives 250 XP.

- 100 XP is used to reach Level 2.
- 150 XP remains.
- Level 2 requires 150 XP.
- The player reaches Level 3.
- Remaining XP becomes 0.

Final state:

- Level: 3
- XP: 0

## Evaluation Task

Review Candidate Solution A and Candidate Solution B.

Determine:

- Which solution better satisfies the requirements.
- Which edge cases may fail.
- Whether either solution contains hidden bugs.
- Which tests should be written.
- What changes would improve the weaker implementation.

Do not assume that code is correct simply because it compiles.

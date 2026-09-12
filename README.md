# C# AI Code Evaluator
[![.NET Tests](https://github.com/3dm0nd2019/csharp-ai-code-evaluator/actions/workflows/dotnet-tests.yml/badge.svg)](https://github.com/3dm0nd2019/csharp-ai-code-evaluator/actions/workflows/dotnet-tests.yml)
A portfolio project demonstrating structured evaluation of AI-generated C# code through requirements analysis, bug detection, automated testing, edge-case analysis, and reference implementations.

## Purpose

AI-generated code can compile successfully while still containing logical bugs, incomplete requirement handling, or poor design decisions.

This repository demonstrates a systematic approach to evaluating generated C# solutions rather than accepting generated code at face value.

Each challenge includes:

- A written specification
- Multiple candidate implementations
- Automated NUnit tests
- Edge-case analysis
- A written evaluation report
- A corrected reference implementation
- Continuous integration using GitHub Actions

## Challenge 01: Player XP and Level Progression

The first challenge evaluates two implementations of a player progression system.

The system must:

- Start at Level 1 with 0 XP
- Increase XP requirements as levels increase
- Preserve leftover XP
- Support multiple level-ups from a single XP award
- Reject negative XP
- Remain clear and testable

### Key Finding

Candidate A correctly handles basic progression but contains a logical defect: it only processes one level-up per XP award.

Candidate B correctly processes repeated level-ups using iterative progression logic.

The reference implementation improves readability, validation, and maintainability.

## Repository Structure

```text
src/
├── Challenges/
├── CandidateSolutions/
└── ReferenceSolutions/

tests/
└── ChallengeTests/

evaluations/
docs/

Evaluation Criteria
Candidate solutions are reviewed for:
1. Correctness
2. Edge-case handling
3. Code quality
4. Error handling
5. Efficiency
6. Testability
7. Requirement compliance
See docs/evaluation-rubric.md for the complete evaluation methodology.
Automated Testing
The project uses:
- .NET 8
- NUnit
- GitHub Actions
Every push and pull request to the main branch automatically restores dependencies, builds the project, and runs the test suite.
Running the Tests Locally
dotnet restore tests/CSharpAiCodeEvaluator.Tests.csproj
dotnet test tests/CSharpAiCodeEvaluator.Tests.csproj
Skills Demonstrated
- C#
- .NET
- NUnit
- Unit testing
- AI-generated code evaluation
- Code review
- Bug detection
- Edge-case analysis
- Requirements analysis
- Git and GitHub
- Continuous integration
- GitHub Actions
Author
Busayo Akinwumi Agboola
C# / Unity Developer focused on software development, AI-assisted programming, code evaluation, and game systems.
LinkedIn: https://ng.linkedin.com/in/busayo-agboola-a58286245
GitHub: https://github.com/3dm0nd2019

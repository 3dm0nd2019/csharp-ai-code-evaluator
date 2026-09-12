# C# AI Code Evaluation Rubric

This repository evaluates AI-generated C# solutions using a consistent set of software engineering criteria.

## 1. Correctness
Does the implementation satisfy all stated functional requirements?

## 2. Edge Cases
Does the implementation correctly handle boundary conditions, unusual inputs, and scenarios that may not occur during normal execution?

## 3. Code Quality
Is the code readable, maintainable, appropriately structured, and easy for another developer to understand?

## 4. Error Handling
Does the solution safely handle invalid input and unexpected conditions?

## 5. Efficiency
Does the implementation avoid unnecessary operations, excessive complexity, or inefficient approaches?

## 6. Testability
Can the implementation be reliably verified using automated unit tests?

## 7. Requirement Compliance
Does the solution implement the requested behavior without omitting requirements or introducing unnecessary functionality?

## Evaluation Outcomes

Each candidate solution receives one of the following conclusions:

- **PASS** - Meets the requirements without significant issues.
- **PASS WITH ISSUES** - Fundamentally correct but contains minor problems.
- **NEEDS REVISION** - Contains significant problems that should be corrected.
- **FAIL** - Does not correctly satisfy the core requirements.

## Evaluation Process

For each challenge:

1. Review the problem specification.
2. Inspect each candidate implementation.
3. Identify potential bugs and edge cases.
4. Create tests designed to verify the requirements.
5. Run the candidate solutions against those tests.
6. Compare correctness, maintainability, and efficiency.
7. Document the findings.
8. Produce a corrected reference implementation when necessary.

The goal is not simply to determine whether code compiles, but whether it behaves correctly, robustly, and predictably under realistic and edge-case conditions.

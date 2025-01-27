## Purpose of the Strategy Pattern
- Encapsulates a family of algorithms.
- Makes algorithms interchangeable.
- Allows the algorithm to vary independently from clients that use it.

## When to Use It
- When you have multiple algorithms for a specific task.
- When you want to avoid conditional statements for selecting algorithms.
- When you need to change the algorithm at runtime.

## When Not to Use It
- When the algorithms do not change or are not interchangeable.
- When the overhead of creating strategy objects is not justified.
- When the complexity added by the pattern outweighs its benefits.

# Answers to Technical Questions

## 1. How long did you spend on the coding assignment? What would you add if you had more time?

I spent approximately 4–5 hours completing the coding assignment.

If I had more time, I would add:

- Unit tests for the Service and Controller layers.
- Response caching to reduce calls to external APIs.
- Better logging and monitoring (e.g., structured logging).
- Improved error handling and validation.
- Docker support for easier deployment.
- CI pipeline configuration.

---

## 2. What was the most useful feature added to the latest version of your language of choice?

One useful feature introduced in modern C# versions (C# 10+) is **Global Using Directives**.

This feature reduces repetitive `using` statements across multiple files.

Example:

csharp
// GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Threading.Tasks;


## 3. How would you track down a performance issue in production? Have you ever had to do this?

To track down performance issues in production, I would:

Enable structured logging and analyze slow requests.

Use profiling and monitoring tools (e.g., Application Insights).

Check database queries and execution plans.

Analyze external API response times.

Monitor CPU, memory, and thread usage.

In a previous project, I identified a slow database query that caused high response times. After analyzing logs and query execution plans, I optimized the query and added indexing, which significantly improved performance.


## 4. What was the latest technical book you have read or tech conference you attended? What did you learn?

Recently, I studied materials related to Clean Architecture principles.

Key takeaways:

Separation of concerns

Dependency inversion principle

Writing maintainable and testable code

Structuring projects in layers (Domain, Application, Infrastructure, Presentation)

These concepts influenced the structure of this assignment.


## 5. What do you think about this technical assessment?

The assessment is clear and practical. It evaluates:

API integration

Clean architecture

Code structure and readability

Problem-solving ability

It is a balanced task that demonstrates both technical and architectural understanding without unnecessary complexity.


## 6. Describe yourself using JSON
{
  "name": "Mohammad Dehghan",
  "role": "Backend Developer",
  "primary_stack": [".NET Core", "C#", "REST APIs"],
  "other_experience": ["Spring Boot", "SQL Databases", "Docker (familiar)"],
  "strengths": ["Problem solving", "Clean code", "Layered architecture"],
  "learning_mindset": true
}
# Repository Pattern
Repository pattern is a design pattern used to separate the logic that retrives data from underlying storage system from rest of the application. It is a part of the broader architectural pattern known as the Data Access Layer.

To understand Repository pattern better, let's consider following diagram.

![Repository Pattern](Images/Repository.jpg)

In general, we write our data access logic within the controller. Which increase code redundancy and  violates the principles of separation of concerns and maintainability in the context of ASP.NET Core MVC. This practice can lead to tightly coupled code, making it challenging to unit test, refactor, and extend the application in a scalable manner.

A better approach is to adhere to the principles of the Repository Pattern and Dependency Injection. By separating data access logic into dedicated repository classes and using dependency injection to inject these repositories into controllers, we can achieve a more modular and maintainable architecture. This allows for easier testing, better code organization, and the ability to switch out data access implementations without affecting the rest of the application.

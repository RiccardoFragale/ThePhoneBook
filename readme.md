# The Phone Book

## Patterns

- *Microservices*: This is considered as a microservice part of a group of microservices therefore a REST api has been added to the project so that other services can interact.
- *MVC*: for the "phone book" I saw no need for a frontend framework to be added (Angular, React) because of the UI being quite simple that would add too much complexity compared to the benefits (both during development and deployments CI/CD).
- *DI*: Dependency Injection is used throughout to decouple services and third party libraries like AutoMapper (which has been wrapped with a class in order for it to be easily substituted).
- *Unit of work pattern*: The data layer implemented through SQL lite "in memory" database works through the Entity Framework ORM and uses the "unit of work" pattern, a unit is created for each query or write operation (multiple operations can be combined in a unit) and then the unit gets executed.
- *Factory pattern*: The dependencied for the "unit of work" are managed via a "factory pattern" which provides every repository in the unit with the reference to the same data context.
- *Cqrs pattern*: In order to be ready for big-data scenarios I use the Cqrs pattern by default and I separate query operations from status-altering operations.
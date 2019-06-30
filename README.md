# Patterns explained through Elephant carpaccio kata

## Elephant carpaccio kata

I really love the elephant carpaccio kata
Instructions can be found here:
https://docs.google.com/document/d/1TCuuu-8Mm14oxsOnlk8DqfZAA1cvtYu9WGv67Yj_sSk/pub

### This is my carpaccio user stories for the elephant carpaccio kata

- As a user I want an app
- As a user I want to haver a price for my items
- As a user I want my clients to know the purchase total
- As a user I want to know my clients to know a fixed tax added to the total
- As a user I want to insert a price
- As a user I want to insert any number of units for a price
- As a user I want to have more than one tax state
- As a user I want to choose my tax state
- As a user I want my state to affect my total amount
- As a user I want my clients to have discount when they spend more than a certain amount
- As a user I want to have many discounts depending on the total amount
- As a user I want my clients’ bill to specify the discount applied
- As a user I want my clients’ total amount to pay to be affected by the discount
- As a user I want to validate price input
- As a user I want to warning when bad price input
- As a user I want to validate number of items input
- As a user I want to warning when bad number of items input
- As a user I want to validate state input
- As a user I want to warning when bad state input

## For the sake of the story let's say:
We are aproached by a client from whom we gather the preceding stories.
We really want to go CD, but our client is kind of old fashion.

### The first 20 Deliveries (00-NoDI app was delivered)
We went all in and we came out with an application that meets our client's criteria.
We delivered many times a day and talked frequently to our client. Our client kind of stalls and responds 
vagelly to our question. After 20 delvieries he realizes that our aproach doesn't fit his companies needs.

#### The old fashion down grade
Our client's developer team doesn't know dotnet core so he asks us to change our development to C# plain old framework. 
Furthermore, he wants to use this new thing called DI his heard about, because that service locator thing his developer use
is doomed or so he read at some blog.

#### Continuous improvement
From what we gathered our client's development does:
- Develop C# Framework apps
- Don't plan to learn dotnet core any time soon
- Use Service locator pattern
- Could be resistent to embrace that DI thing they are being forced upon

After a nice retrospective at our offices we realized that there is a framework that can solve all our problems.
**Simple IOC (MVVMLight lib)** has a kind of service locator flavor and uses DI. So let's meet out client's need and deliver some value.
While we are at it we'll try to move to configuration files the taxing an discount lists

### Microservices on WebApi2
We delivered (01-AntiPattern) on time so now our client is happy because he sees value in configuration files.
He wants to go to the next level and has heard of this Microservice thing. 
Since his development team has some experience using Asp.net MVC he is confident that they will have no problem with a Web Api 2 application.
Since simple IOC(MVVMLight lib) has quickly embraced  by his development team, now his heard of Unity IOC and wants it in the new project

### Patterns ilustration

To explain some patterns int this project I've implemented the following patterns:
- 00-NoDI
	- [Service Locator Pattern](SERVICELOCATOR.md)
	- [Poor man's DI](POORMANSDI.md)
- 01-AntiPattern
	- [Antipatter](ANTIPATTER.md)

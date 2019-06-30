# Poor man’s DI
## Composition and frameworks
The typical strategy for applying DI is to use a framework of the wide variety available.
The ones I've used through my carrier are:
- Autofac
- Structure Map
- Ninject
- Unity IOC
- Built In dotnet core Injection Framework

But my first contact with Dependency Injection was through a Framework called Simple IOC, though some say it is an antipattern for me was the easiest to figure out.

### No magic only composition an reflection
The first reaction of *noob* when told about Inversion of Control is that they can't wrap their head 
around what appends under the hood. That is a common and understandable reaction so for teaching purposes let's explore poor man’s DI.

#### Registering dependencies in Dictionaries
Here in this article Stefano Riccardi does an excelent job
http://www.stefanoricciardi.com/2009/09/25/service-locator-pattern-in-csharpa-simple-example/


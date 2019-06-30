# Service Locator 
## What is a Service Locator?

One of the first patterns I learned along MVVM was the **Service Locator Pattern**.
### Service Locator Pattern
I’ve read great many things about this pattern some say it’s an ***antipattern*** some say is a way of implementing [DI](DI.md)
was the **Service Locator Pattern**

#### How I learned the Service Locator pattern
**Service Locator** Is simply a singleton that has your software Dependencies as properties.

```csharp
public static class ServiceLocator
{
	private static RetailCalculatorService retailCalculatorService;
    public static RetailCalculatorService RetailCalculatorService
    {
		get
		{
			if (retailCalculatorService == null)
			{
				retailCalculatorService = CreateRetailCalculatorService();
			}
			return retailCalculatorService;
		}
    }
}
```
This particular instance of code would be called as ServiceLocator.RetailCalculatorService in order to get the instance of our class
(**Word of advice** this was kept simple for teaching purposes but It would work much better if you did lazy instantiation memory wise)

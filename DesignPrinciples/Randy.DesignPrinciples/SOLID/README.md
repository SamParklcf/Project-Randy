# Project-Randy
Randy is a great teacher to inspire you do more

## Design Principles 
Here is a section to know all about Design Principles.

### What are Design Principles?
Design Principles are a set of guidelines that helps developers to make a good system design.

### SOLID
**S**ingle Responsibility Principle: A class should have a single responsibility. in other hands, This principle states that there should never be more than one reason for a class to change.
If a Class has many responsibilities, it increases the possibility of bugs because making changes to one of its responsibilities, could affect the other ones without you knowing.
This principle aims to separate behaviours so that if bugs arise as a result of your change, it won’t affect other unrelated behaviours.

Bad practice:
```C#
	public class SchoolManager
	{
		public void SaveStudent(){}
		public void ReadStudent(){}

		public void SaveLesson(){}
		public void ReadLesson(){}
	}
```

Good practice:
```C#
	public class StudentManager
	{
		public void SaveStudent(){}
		public void ReadStudent(){}
	}

	public class LessonManager
	{
		public void SaveLesson(){}
		public void ReadLesson(){}
	}
```

 **O**pen-Closed Principle: Classes should be open for extension, but closed for modification. Of all the principles of object oriented design, this is the most important.
 It means simply this: We should write our modules so that they can be extended, without requiring them to be modified. 
 In other words, we want to be able to change what the modules do, without changing the source code of the modules.

 ![Open-Closed principle](https://miro.medium.com/max/1400/1*0MtFBmm6L2WVM04qCJOZPQ.png)

 Changing the current behaviour of a Class will affect all the systems using that Class. This principle aims to extend a Class’s behaviour without changing the existing behaviour of that Class. 
 This is to avoid causing bugs wherever the Class is being used.

There are several techniques for achieving the OCP on a large scale. All of these techniques are based upon **abstraction**. Indeed, **abstraction** is the key to the OCP. 
- **Dynamic Polymorphism:** States that you should have diffenrent classes including same concept action instead of iterating these actions throw if...else or
switch statements. (see code for better understanding)
- **Static Polymorphism**: You can use generic types to achieve the OCP. (see code for more information)

By using these techniques to conform to the OCP, we can create modules that are extensible, without being changed. This means that, with a little forethought, we can add new features to existing code, without 
changing the existing code and by only adding new code.</br>
Even if the OCP cannot be fully achieved, even partial OCP compliance can make dramatic improvements in the structure of an application. 
It is always better if changes do not propogate into existing code that already works. If you don’t have to change working code, you aren’t likely to break it.

**L**iskov Substitution Principle: Subclasses should be substitutable for their base classes.
In other words, This principle states that functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
Assume that you have an inheritance hierarchy with Person and Student. Wherever you can use Person, you should also be able to use a Student, because Student is a subclass of Person.

![Liskov Substitution Principle](https://miro.medium.com/max/1400/1*yKk2XKJaCLNlDxQMx1r55Q.png)

When a child Class cannot perform the same actions as its parent Class, this can cause bugs.
If you have a Class and create another Class from it, it becomes a parent and the new Class becomes a child. 
The child Class should be able to do everything the parent Class can do. This process is called Inheritance.
The child Class should be able to process the same requests and deliver the same result as the parent Class or it could deliver a result that is of the same type.
If the child Class doesn’t meet these requirements, it means the child Class is changed completely and violates this principle.
This principle aims to enforce consistency so that the parent Class or its child Class can be used in the same way without any errors.

**I**nterface Segregation Principle: Many client specific interfaces are better than one general purpose interface. or
Clients should not be forced to depend on methods that they do not use. This means the number of members in the interface that is visible to the dependent class should be minimized.

![Interface Segregation Principle](https://miro.medium.com/max/1400/1*2hmyR9L43Vm64MYxj4Y89w.png)

When a Class is required to perform actions that are not useful, it is wasteful and may produce unexpected bugs if the Class does not have the ability to perform those actions.
A Class should perform only actions that are needed to fulfil its role. Any other action should be removed completely or moved somewhere else if it might be used by another Class in the future.
This principle aims at splitting a set of actions into smaller sets so that a Class executes ONLY the set of actions it requires.

**D**ependency Inversion Principle: Depend upon Abstractions. Do not depend upon concretions. If the OCP states the goal of OO architecture, the DIP states the primary mechanism. 
Dependency Inversion is the strategy of depending upon interfaces or abstract functions and classes, rather than upon concrete functions and classes. 
This principle is the enabling force behind component design, COM, CORBA, EJB, etc. </br>
In other words, High-level modules should not depend on low-level modules. Both should depend on the abstraction. 
Abstractions should not depend on details. Details should depend on abstractions.
- **High-level Module(or Class):** Class that executes an action with a tool.
- **Low-level Module (or Class):** The tool that is needed to execute the action
- **Abstraction:** Represents an interface that connects the two Classes.
- **Details:** How the tool works

It helps us to develop loosely couple code by ensuring that high-level modules depend on abstractions rather than concrete implementations of lower-level modules. 
The Dependency Injection pattern is an implementation of this principle.

![Depenency Inversion Principle](https://miro.medium.com/max/1400/1*Qk8tDmjQlyvwKxNTfXIo0Q.png)

This principle says a Class should not be fused with the tool it uses to execute an action. Rather, it should be fused to the interface that will allow the tool to connect to the Class.
It also says that both the Class and the interface should not know how the tool works. However, the tool needs to meet the specification of the interface.
This principle aims at reducing the dependency of a high-level Class on the low-level Class by introducing an interface.


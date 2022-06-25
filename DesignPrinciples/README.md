# Project-Randy
Randy is a great teacher to inspire you do more

## Design Principles 
Here is a section to know all about Design Principles.

### What are Design Principles?
Design Principles are a set of guidelines that helps developers to make a good system design.

### Symptoms of Rotting Design
 - **Rigidity:** is the tendency for software to be difficult to change, even in simple ways. Every change causes a cascade of subsequent changes in dependent 
modules. What begins as a simple two day change to one module grows into a multiweek marathon of change in module after module as the engineers chase the thread of 
the change through the application.
 - **Fragility:** Closely related to rigidity is fragility. Fragility is the tendency of the software to break in many places every time it is changed. 
 Often the breakage occurs in areas that have no conceptual relationship with the area that was changed. Such errors fill the hearts of managers with foreboding. 
 Every time they authorize a fix, they fear that the software will break in some unexpected way.
  - **Immobility:** Immobility is the inability to reuse software from other projects or from parts of the same project. It often happens that one engineer will discover that he 
needs a module that is similar to one that another engineer wrote. However, it also often happens that the module in question has too much baggage that it depends upon. 
After much work, the engineers discover that the work and risk required to separate the desirable parts of the software from the undesirable parts are too great to tolerate. 
And so the software is simply rewritten instead of reused.
 - **Viscosity:** Viscosity comes in two forms: viscosity of the design, and viscosity of the environment. When faced with a change, engineers usually find more than one 
way to make the change. Some of the ways preserve the design, others do not (i.e. they are hacks.) When the design preserving methods are harder to employ than the 
hacks, then the viscosity of the design is high. It is easy to do the wrong thing, but hard to do the right thing.
Viscosity of environment comes about when the development environment is slow and inefficient. For example, if compile times are very long, engineers will be 
tempted to make changes that don�t force large recompiles, even though those changes are not optiimal from a design point of view. 
If the source code control system requires hours to check in just a few files, then engineers will be tempted to make changes that require as few check-ins as possible, regardless of whether the design is preserved.

**What kind of changes cause designs to rot?** Changes that introduce new and unplanned for dependencies. Each of the four symptoms mentioned above is either 
directly, or indirectly caused by improper dependencies between the modules of the software. 
It is the dependency architecture that is degrading, and with it the ability of the software to be maintained.

- [SOLID](/DesignPrinciples/Randy.DesignPrinciples/SOLID/README.md)
    - Single Responsibility
    - Open-Closed
    - Liskov Substitution
    - Interface Segregation
    - Depenendency Inversion
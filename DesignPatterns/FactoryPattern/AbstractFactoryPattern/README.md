Abstract Factory Pattern steps:
    1. One Main Interface
    2. ConcreteClass which will implement the Interface.
    3. One FactoryInterface.
    4. ConcreteFactories which will implement FactoryInterface and creates the object of the ConcreteClasses depending on the types. 
    5. Client will access Specific factory first with a FactoryInterface type. And then tell the type of class and factory will create an object of that type.
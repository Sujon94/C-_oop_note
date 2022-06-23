<h3>Static Class:</h3>
    <li>Static classes cannot be instantiated/can not make object of a static class.</li>
    <li>All the members of a static class must be static; otherwise the compiler will give an error.</li>
    <li>Static can not contain non-static members.</li>
    <li>Indexers and destructors cannot be static</li>
    <li>Var can't be used. Need specify specific data type.</li>
    <li>Can't be inherited</li>
    <li>Can't inherit other class</li>
    <li>To access static member: </li>
        Example:

        ClassName.staticMember;
    
<h3>None static class with static members:
    <li>Can define multiple static property, methods etc.</li>
    <li>Static methods can access only static elements.</li>
    <li>Can't access static members by the object of a none-static class.</li>
    <li>Static members must be accessed by parent class name only.</li>
    <li>Static methods can't be overridden can be overloaded.</li>
    <li>Parameterized static constructors are not allowed.</li>
    <li>Static constructor will be executed only once in the lifetime.</li>
<h3>Const:</h3>
    <li>Const value can't be changed.</li>
    <li>It will show compile error if not initialize at declaration.</li>
    Example:

    const string c="Hello";

<h3>Readonly:</h3>
    <li>Readonly value can be changed only inside non-static constructor at run time.</li>
    Example: 

    readonly string re = "Hello";
    public constructor(){
        re = "Allowed here";
    }
    
    static constructor(){
        re = "Not allowed";
    }

    public string NewFunction(){
        re = "Not allowed";
    }

<h3>Readonly Static:</h3>
    <li>Readonly value can be changed only inside static constructor.</li>
    Example:

    readonly static string rse = "Hello";

    public constructor(){
        rse = "Not allowed here";
    }

    static constructor(){
        rse = "Allowed here";
    }

    public string NewFunction(){
        rse = "Not allowed";
    }
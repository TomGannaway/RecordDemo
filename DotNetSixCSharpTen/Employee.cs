


namespace DotNetSixCSharpTen;

internal class Employee // public, private, internal
{

    public Employee()
    {
        var conn = new SqlConnection();
    }

    protected string GetInfo() // public means anyone that has an instance of this class can use this method.
        // private means just for use in this class (a helper method)
        // internal means other code in this same assembly can use this, but nobody outside.
        // protected means other instances of this same class or any class that inherits from it. "In the family"
    {
        return "This is an a employee";
    }

    private class Tacos { }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSixCSharpTen;

public class ShippingService
{

    public void ShipPackage(Package p)
    {
        // do some shipping stuff with this.
        // p.RequiredBy = DateTime.Now.AddDays(51);
    }

    public Package DeferFor(int day, Package p)
    {
        var result = p with { RequiredBy = p.RequiredBy.AddDays(day) };
        return result;
    }

    public FormatNameResponse FormatName(string first, string last)
    {
        var fullName = last + ", " + first;
        return new FormatNameResponse(fullName.Length, fullName);
    }


}

public record FormatNameResponse(int length, string formattedName);
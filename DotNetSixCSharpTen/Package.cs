
namespace DotNetSixCSharpTen;

public record Package
{
   
    public string To { get; init ; } = String.Empty;
    public DateTime RequiredBy { get; init; }

    public List<string> AcceptSignaturesFrom { get; set; } = new();
}


public record TodoItem(int Id, string Description, DateTime due, bool completed);
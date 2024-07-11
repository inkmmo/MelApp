using System.Collections.Generic;

namespace Melapp.Models;

public class CollectionEntry
{
    public int RowNumber { get; set; }
    public string Value1 { get; set; }
    public string Value2 { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
}
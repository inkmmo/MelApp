using System.Collections.Generic;

namespace Melapp.Models;

public class Collection
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value1Count { get; set; }
    public int Value2Count { get; set; }
    public List<CollectionEntry> Entries { get; set; }
}
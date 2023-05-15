using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Item
{
    public string? Name { get; set; }

    public int Id { get; set; }

    public bool? IsComplete { get; set; }
}

using System.Collections;
using System.Collections.Generic;

public class EasyCapacity 
{
    string description;
    string inClient;
    string owned;
    string difference;

    public EasyCapacity(string description, string inClient, string owned, string difference)
    {
        this.Description = description;
        this.InClient = inClient;
        this.Owned = owned;
        this.Difference = difference;   
    }

    public string Description { get => description; set => description = value; }
    public string InClient { get => inClient; set => inClient = value; }
    public string Owned { get => owned; set => owned = value; }
    public string Difference { get => difference; set => difference = value; }
}

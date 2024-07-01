using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
public class EasyLocation
{
    string description;
  
    public EasyLocation(string description)
    {
        this.Description = description; 
    }

    public override string ToString()
    {
        return description;
    }

    public string Description { get => description; set => description = value; }
}

using System.Collections;
using System.Collections.Generic;
public class EasyDataLine 
{
    string code;
    string description;

    public EasyDataLine(string code, string description)
    {
        this.Code = code;
        this.Description = description;
    }

    public string Code { get => code; set => code = value; }
    public string Description { get => description; set => description = value; }
}

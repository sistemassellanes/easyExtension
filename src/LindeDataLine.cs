using System.Collections;
using System.Collections.Generic;

public class LindeDataLine 
{
    string code;
    string delayedDays;
    string deliveredDate;

    public LindeDataLine(string code, string delayedDays, string deliveredDate)
    {
        this.Code = code;
        this.DelayedDays = delayedDays;
        this.DeliveredDate = deliveredDate;
    }

    public string Code { get => code; set => code = value; }
    public string DelayedDays { get => delayedDays; set => delayedDays = value; }
    public string DeliveredDate { get => deliveredDate; set => deliveredDate = value; }
}

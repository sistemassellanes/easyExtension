using System.Collections;
using System.Collections.Generic;
public class EasyCylinder
{
    string serial;
    string description;
    string movementNumber;
    string movementType;
    string movementDate;
    string days;
    bool itsLinde;
    bool itsAlmostLinde;

    public EasyCylinder(string serial, string description, string movementNumber, string movementType, string movementDate, string days)
    {
        this.Serial = serial;
        this.Description = description;
        this.MovementNumber = movementNumber;
        this.MovementType = movementType;
        this.MovementDate = movementDate;
        this.Days = days;
    }

    public string ItsLindeDescription()
    {
        if (itsLinde)
        {
            return "RECLAMADO";
        }else if (itsAlmostLinde)
        {
            return "PUEDE SER LINDE";
        }
        return "";
    }

    public bool ItsLinde { get => itsLinde; set => itsLinde = value; }
    public string Description { get => description; set => description = value; }
    public string MovementNumber { get => movementNumber; set => movementNumber = value; }
    public string Days { get => days; set => days = value; }
    public string MovementType { get => movementType; set => movementType = value; }
    public string MovementDate { get => movementDate; set => movementDate = value; }
    public string Serial { get => serial; set => serial = value; }
    public bool ItsAlmostLinde { get => itsAlmostLinde; set => itsAlmostLinde = value; }

    public override string ToString()
    {
        return "Serial: " + Serial + " Description: " + Description + " MovementNumber: " + MovementNumber + " MovementType: " + MovementType + " Date: " + MovementDate + " Days: " + Days ;
    }
}

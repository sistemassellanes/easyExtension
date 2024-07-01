using System.Collections;
using System.Collections.Generic;
public class EasyClient
{
    string id;
    string code;
    string name;
    string address;
    string number;
    string rut;
    string socialNumber;
    EasyLocation easyLocation;
    
    List<EasyCylinder> listCylinder;
    List<EasyCapacity> listCapacity;


    public EasyClient()
    {
        this.ListCylinder = new List<EasyCylinder>();
        this.ListCapacity = new List<EasyCapacity>();
    }

    public void AddCylinder(EasyCylinder cylinder)
    {
        ListCylinder.Add(cylinder);
    }

    public void AddCapacity(EasyCapacity capacity)
    {
        ListCapacity.Add(capacity);
    }

    public override bool Equals(object? obj)
    {
        return id.Equals(obj);
    }

    public void LogCapacity()
    {
        foreach(EasyCapacity capacity in ListCapacity)
        {
            //Debug.Log("Capacidad: " + capacity.Description);
        }
    }

    public void LogCylinders()
    {
        foreach (EasyCylinder cylinder in ListCylinder)
        {
            //Debug.Log("Cilindro Serial: " + cylinder.Serial + " Description: " + cylinder.Description);
        }
    }

    public bool CheckIfIHaveSomeLindeCylinder()
    {
        bool result = false;
        foreach (EasyCylinder cylinder in ListCylinder)
        {
            if (cylinder.ItsLinde)
            {
                result = true;
                return true;
            }
        }
        return result;
    }

    public string Name { get => name; set => name = value; }
    public string Id { get => id; set => id = value; }
    public string Address { get => address; set => address = value; }
    public string Number { get => number; set => number = value; }
    public EasyLocation EasyLocation { get => easyLocation; set => easyLocation = value; }
    public string Rut { get => rut; set => rut = value; }
    public string SocialNumber { get => socialNumber; set => socialNumber = value; }
    public string Code { get => code; set => code = value; }
    public List<EasyCylinder> ListCylinder { get => listCylinder; set => listCylinder = value; }
    public List<EasyCapacity> ListCapacity { get => listCapacity; set => listCapacity = value; }

    public override string ToString()
    {
         return name;
    }
}

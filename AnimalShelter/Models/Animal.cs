namespace AnimalShelter.Models
{
  public class Animal
  {
    public int Animal_Id {get; set;}
    public string Name {get; set;}
    public string Date {get;set;}
  }

  public Animal(string name, string date)
  {
   Animal_Id = Animal_Id;
   Name = name;
   Date = date;

  }
  public Animal(string date)
  {
   Animal_Id = Animal_Id;
   Name = name;
   Date = date;

  }
}
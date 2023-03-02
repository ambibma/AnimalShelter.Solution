namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }


    //String => Cast as DATETIME mysql
    public string Date { get; set; }
  
    // public Animal(string name, string date)
    // {
    // Animal_Id = Animal_Id;
    // Name = name;
    // Date = date;

    // }
    
    // public Animal(string date)
    // {
    // Animal_Id = Animal_Id;
    
    // Date = date;

    // }
  }
}
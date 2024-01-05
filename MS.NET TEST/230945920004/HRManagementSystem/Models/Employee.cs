namespace BOL;

public class Employee{
    public int Id{ get; set; }
    public string Name{ get; set; }
    public string Email{ get; set; }
    public string ContactNumber{ get; set; }

    public Employee() : this(0, "Employee_0", "employee@email", "employee_phone"){}
    public Employee(int id, string name, string email, string contactNumber){
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.ContactNumber = contactNumber;
    }
}
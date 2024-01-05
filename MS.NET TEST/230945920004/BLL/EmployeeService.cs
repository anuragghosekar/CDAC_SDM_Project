namespace BLL;
using BOL;
using DAL;

public class EmployeeService{
    public static List<Employee> DisplayAllEmployee()
    {
        var lst = DBManager.DisplayAll();
        return lst;
    }
}
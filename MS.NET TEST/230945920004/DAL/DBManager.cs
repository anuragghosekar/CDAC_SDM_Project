namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public static class DBManager
{
    public static string connectString = "server=1923168.10.150; port=3306; user=dac4; password=welcome; database=dac4"; 
    public static List<Employee> DisplayAll()
{
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString=connectString;
    string query = "select * from Employee";
    MySqlCommand cmd = new MySqlCommand(query, con);
    List<Employee> pList = new List<Employee>();
    try{
        con.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            int id = int.Parse(reader["id"].ToString());
            string name = reader["name"].ToString();
            string email = reader["email"].ToString();
            string contactnumber = reader["ContactNumber"].ToString();
            Employee p = new Employee(id, name, email, contactnumber);
            // Console.WriteLine(p);
            pList.Add(p);
        }
        reader.Close();
            // Console.WriteLine(pLit);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    } finally{
        con.Close();
    }
    return pList;
}

public static void InsertEmployee(Employee e)
{
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString=connectString;
    string query = "insert into Employee (id, name, email, ContactNumber) values ('"+e.Id+"','"+e.Name+"','"+e.Email+"','"+e.ContactNumber+"')";
    MySqlCommand cmd = new MySqlCommand(query,con);
    try{
        con.Open();
        cmd.ExecuteNonQuery();
    }
    catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
    finally{
        con.Close();
    } 
}

public static void UpdateEmployee(Employee e)
{
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString=connectString;
    string query = "UPDATE Employee SET id='"+e.Id+"', name='"+e.Name+"', email='"+e.Email+"', ContactNumber='"+e.ContactNumber+"' where id='"+e.Id+"'";
    MySqlCommand cmd = new MySqlCommand(query, con);
    try{
        con.Open();
        cmd.ExecuteNonQuery();
    }
    catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
    finally{
        con.Close();
    }
}


public static void DeleteEmployee(int id)
{
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString=connectString;
    string query = "delete from Employee where id="+id;
    MySqlCommand cmd = new MySqlCommand(query, con);
    try{
        con.Open();
        cmd.ExecuteNonQuery();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally{
        con.Close();
    }
} 
}
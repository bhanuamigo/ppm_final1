namespace Program.Model.modl
{




public class Project
{
    public List<Employee> AddingEmplist = new List<Employee>();
    public int? id { get; set; }
    public string ProjectName { get; set; }
    public string Startdate { get; set; }
    public string Enddate { get; set; }
    


    public Project(string projectname, string startdate, string enddate, int Id)
    {
        this.id = Id;
        this.ProjectName = projectname;
        this.Startdate = startdate;
        this.Enddate = enddate;
        
    }
    public Project()
    {

    }
}
    public class Employee
{
    public int EmployeeID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string address { get; set; }
    public int roleid { get; set; }
    public string roleName { get; set; }


    public Employee(int empid, string FirstName, string LastName, string Email, string Mobile, string Address, int RoleID, string Rolename)
    {
        this.EmployeeID = empid;
        this. firstName = FirstName;
        this.lastName = LastName;
        this.email = Email;
        this.mobile = Mobile;
         this. address = Address;
        this.roleid = RoleID;
        this.roleName = Rolename;
    }

    public Employee()
    {

    }
}
    public class Role
{
    public string RoleName { get; set; }
    public int RoleId { get; set; }

    public Role(int roleid, string roleName)
    {
       this.RoleName = roleName;
        this.RoleId = roleid;
    }
}
}



 
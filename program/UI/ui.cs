using Program.Model.modl;
using PROGRAM.DOMINE.domine;
namespace PROGRAM.UI.ui
{


class ui 
{
   public void viewing(){

        Console.Write("\n PROLIFICS PROJECT MANAGEMENT\n");
        Console.Write(" \n [Enter 1 for add project] \t"        + "   [Enter 2 to view all projects ] \t"     +   "  [Enter 3 for addEmployee] \t "   
                 + "\n \n [Enter 4 for view all Employees] \t" + "[Enter 5 for add Role] \t "              +  "         [Enter 6 for view all Roles] \t "
                +"\n \n  [Enter 7 for search project] \t"      +      "    [Enter 8 for search project through id] \t"   + "\n \n  [Enter 9 add project to employee] \t " 
                 + "\n \n [ Enter 10 to view project details ] \t " +"\n \n [Enter x to exit application] "); 
           
        Projectdata obj = new Projectdata();
        Employee employee = new Employee();
        Project project = new Project();
        EmpManagement obj1 = new EmpManagement();
        RoleManagement obj2 = new RoleManagement();
        // AddingEmpProject obj3 = new AddingEmpProject();
        obj2.RoleList.Add(new Role(1,"Manager"));
        obj2.RoleList.Add(new Role(2,"Asst.Manger"));
        obj2.RoleList.Add(new Role(3,"Software Engineer" ));
        obj2.RoleList.Add(new Role(4,"Associate Software Engineer" ));
        obj2.RoleList.Add(new Role(5,"Trainee Software Engineer" ));


        Console.WriteLine("");
        Boolean error = false;
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    do{
                    try
                    {
                        
                        ProjectId:
                        
                        Console.WriteLine("Enter Project Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i< obj.Prolifics.Count;i++){
                        if(obj.Prolifics[i].id == id){
                            Console.WriteLine("The id already exists");
                            Console.WriteLine("");
                                                        Console.WriteLine("Enter any key to try again");
                                                        Console.WriteLine("Press x to get to main menu");

                            var tryid = Console.ReadLine();
                            if(tryid == "x"){
                               goto breakage;
                            }
                            else{
                                goto ProjectId;
                            }
                            }
                        }
                        
                        Console.WriteLine("Enter the name of project");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string start = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string end = Console.ReadLine();
                        Project project1 = new Project(name, start, end, id);
                        project = project1;
                        obj.Addproject(project);
                        Console.WriteLine("");
                        Console.WriteLine(" PROJECT Added Successfully!");
                        Console.WriteLine("");
                        Console.WriteLine("Enter any key for main menu");
                        Console.ReadLine();
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("\nError : Only use number for id");

                    }}while(error);
                    breakage:
                    break;
                case "2":
                    obj.viewAllProjects();
                     Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;

                case "3":
                     ProjectempId:
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i< obj1.empList.Count;i++){
                        if(obj1.empList[i].EmployeeID == empId){
                            Console.WriteLine("The id already exists");
                            Console.WriteLine("");
                                                        Console.WriteLine("Enter any key to try again");
                                                        Console.WriteLine("Press x to get to main menu");

                            var tryid = Console.ReadLine();
                            if(tryid == "x"){
                               goto breakage;
                            }
                            else{
                                goto ProjectempId;
                            }
                            }
                        }
                        
                    Console.WriteLine("Enter employee first name");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Enter employee email id");
                    string EMAIL = Console.ReadLine();
                    Console.WriteLine("Enter employee mobile number");
                    string m_number = Console.ReadLine();
                    Console.WriteLine("Enter address of the employee");
                    string address = Console.ReadLine();
                    Console.WriteLine("Select 1 add role ID to employe");
                    Console.WriteLine("Select 2 for new  role to the employee");
                    int selecting = Convert.ToInt32(Console.ReadLine());
                    if (selecting == 1)
                    {
                        try
                        {
                           obj2.displayRole();
                            Console.WriteLine("Select Role id from above list to assign role to employee");
                            int r1 = Convert.ToInt32(Console.ReadLine());
                            string? rN1 = null;
                            switch (r1)
                            {
                                case 1:
                                    rN1 = "Manager";
                                    break;
                                case 2:
                                    rN1 = " Asst.Manager";
                                    break;
                                case 3:
                                    rN1 = " Software Engineer";
                                    break;
                                case 4:
                                    rN1 = " Associate Software Engineer";
                                    break;
                                case 5:
                                    rN1 = "Trainee Software Engineer";
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry");
                                    break;
                            }
                            Employee eadd = new Employee(empId, fname, lname, EMAIL, m_number, address, r1, rN1);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine(" \n \n Added Successfully");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n \n Emp ID in formate eg: 1234 ");
                        }
                    }
                    else if (selecting == 2)
                    {
                        try
                        {
                            Console.WriteLine("Enter  Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter  name of the  Role");
                            string role_name = Console.ReadLine();
                            Console.WriteLine(role_name);
                            Role newRole = new Role(roleID, role_name);
                            obj2.RoleAdd(newRole);
                            Employee eadd = new Employee(empId, fname, lname, EMAIL, m_number, address, roleID, role_name);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine("\n \n ...Added Successfully...\t");
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Role Id should be  numbers");
                        }
                    }
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get back to main menu");
                            Console.ReadLine();
                            break;
                case "4":
                    obj1.ShowEmp();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine(" \n \n Enter  Role Id \t ");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of the  Role");
                        string role_name = Console.ReadLine();
                        Console.WriteLine(role_name);
                        Role newRole = new Role(roleID, role_name);
                        obj2.RoleAdd(newRole);
                        Console.WriteLine("\n \n ...Added Successfully...\t");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Role Id should only be in number formate ");
                    }
                    Console.WriteLine("\n \n Enter any key to get  back to main menu \t ");
                    Console.ReadLine();
                    break;

                case "6":
                    obj2.displayRole();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("search for project");
                    read = Console.ReadLine();
                    obj.SearchProject(read);
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter  id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get back to main menu");
                    }
                    catch (Exception ) 
                    {
                         Console.WriteLine("Id should be in numbers formate"); 
                    }
                    break;
                case "9":
                     Console.WriteLine("");
                    obj.viewAllProjects();
                    Console.WriteLine("Above are the available projects");
                    Console.WriteLine();
                    obj1.ShowEmp();
                    Console.WriteLine("Above are the available employees");
                    Console.WriteLine("Enter the Id of the project for which you want to add employees");
                    int PROJId = Convert.ToInt32(Console.ReadLine());
                    if(obj.exist(PROJId))
                    {
                         Console.WriteLine("Enter the id of employee to add into project");
                        int EmpId = Convert.ToInt32(Console.ReadLine());
                        if( obj1.exist(EmpId)){
                            employee = obj1.eDetails(EmpId);
                            obj.emptopro(PROJId,employee);
                            //AddingEmptoProject addition = new AddingEmptoProject();
                            //addition.addingemp();
                            Console.WriteLine("Added Successfully!!!!!!!");
                             Console.WriteLine("Enter any key to get to main menu");
                            Console.ReadLine();
                        }
                        else{
                             Console.WriteLine("Employee does not exist");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Project does not exist");
                    }
                    //  }
                    var Read = Console.ReadLine();
                    break;

                case "10":
                    Console.WriteLine("Enter Project Id");
                         int pid = Convert.ToInt32(Console.ReadLine());
                    obj.Display();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
        
   
        
        Console.Write("\n PROLIFICS PROJECT MANAGEMENT\n");
        Console.Write(" \n [Enter 1 for add project] \t"        + "   [Enter 2 to view all projects ] \t"     +   "  [Enter 3 for addEmployee] \t "   
                 + "\n \n [Enter 4 for view all Employees] \t" + "[Enter 5 for add Role] \t "              +  "         [Enter 6 for view all Roles] \t "
                +"\n \n  [Enter 7 for search project] \t"      +      "    [Enter 8 for search project through id] \t" +"[Enter 9 to add employee to project] \t" 
            + "\n \n  [Enter 10 to view  project details ] \t "          +   "\n [\n \nEnter x to exit application] "); 
           Console.WriteLine("Select operation from above list");
        read = Console.ReadLine();
        }
    }
   }

}

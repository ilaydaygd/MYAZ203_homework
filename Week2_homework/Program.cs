using Week2_homework;

class Program
{
    public static void Main()
    {
        Employee emp1 = new Employee(1, "İlayda", "YIGID");
        Employee emp2 = new Employee(2, "Ayşe", "YILMAZ");
        Employee emp3 = new Employee(3, "Alper", "KAYA");
        

        EmployeeManager employeeManager = new EmployeeManager(emp1);

        employeeManager.CreateEmployee(emp1);
        //employeeManager.CreateEmployee(emp2);
        //employeeManager.CreateEmployee(emp3);

        employeeManager.DeleteEmployee(5);
        employeeManager.DeleteEmployee(1);

        employeeManager.ReadList();
    }
}











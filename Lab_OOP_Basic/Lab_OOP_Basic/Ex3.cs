
namespace Lab_OOP_Basic
{
    internal class Employee
    {
        String name;
        int salary;
        int workHourPerDay;
        int salaryPerHour;
        public Employee (string name, int workHourPerDay, int salaryPerHour)
        {
            this.name = name;
            this.workHourPerDay = workHourPerDay;
            this.salaryPerHour = salaryPerHour;
            this.salary = this.salaryPerHour * this.workHourPerDay * 30;
        }

        public void getInfo() 
        {
            Console.WriteLine(this.name + " " + this.salary + "$");
        }
        public void addSal()
        {
            if (this.salary < 500) this.salary += 10;
        }
        public void addWork()
        {
            Console.WriteLine(this.workHourPerDay > 6);
            if (this.workHourPerDay > 6) this.salary +=  5;
        }
    }
}

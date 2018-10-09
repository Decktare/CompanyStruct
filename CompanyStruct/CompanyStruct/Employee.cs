namespace CompanyStruct
{
    public class Employee
    {
        public string Name { get; set; }
        public string Departament { get; set; }
        public string Capacity { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}

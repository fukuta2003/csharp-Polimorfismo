namespace PoliformismoFuncionarios.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueperHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valueperHour)
        {
            Name = name;
            Hours = hours;
            ValueperHour = valueperHour;
        }

        // virtual pois vai ser utilizada por override em outra classe
        public virtual double Payment()
        {
            return ValueperHour * Hours;
        } 
    }
}

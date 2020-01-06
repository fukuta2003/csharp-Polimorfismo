namespace PoliformismoFuncionarios.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionCharge { get; set; }


        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valueperHour, double additioncharge)
           : base(name, hours, valueperHour)
        {
            AdditionCharge = additioncharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionCharge;

        }
    }
}

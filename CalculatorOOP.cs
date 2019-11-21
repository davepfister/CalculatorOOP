namespace OOPDiscussion
{
    internal class CalculatorOOP
    {
        //Constructor
        public CalculatorOOP()
        {


        }

        //Properties
        public double value1 { get; set; }

        public double value2 { get; set; }

        //Function
        public double sum()
        {
            double result = value1 + value2;

            clearValues();

            return result;
        }

        //Method
        public void clearValues()
        {
            this.value1 = 0;
            this.value2 = 0;
        }
    }
}

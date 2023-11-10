namespace Lab7_1
{
    public class Calculator<T>
    {
        public delegate T AdditionDelegate(T a, T b);
        public delegate T SubtractionDelegate(T a, T b);
        public delegate T MultiplicationDelegate(T a, T b);
        public delegate T DivisionDelegate(T a, T b);

        public AdditionDelegate Add { get; set; }
        public SubtractionDelegate Subtract { get; set; }
        public MultiplicationDelegate Multiply { get; set; }
        public DivisionDelegate Divide { get; set; }

        public Calculator()
        {
            Add = (a, b) => (dynamic)a + b;
            Subtract = (a, b) => (dynamic)a - b;
            Multiply = (a, b) => (dynamic)a * b;
            Divide = (a, b) => (dynamic)a / b;
        }

        public T PerformAddition(T a, T b) => Add(a, b);
        public T PerformSubtraction(T a, T b) => Subtract(a, b);
        public T PerformMultiplication(T a, T b) => Multiply(a, b);
        public T PerformDivision(T a, T b) => Divide(a, b);
    }
}

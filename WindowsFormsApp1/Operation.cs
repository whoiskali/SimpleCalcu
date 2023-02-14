using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum OperationEnum
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Equals,
        SquareRoot,
        Squared,
        Rational
    }

    public class Operation
    {
        public Operation()
        {
            MPlus = new List<double>();
            MLess = new List<double>();
        }
        double _answer = 0;
        string _expression = "";
        public double Answer { get { return _answer; } }
        public string Expression { get { return _expression; } }
        public List<double> MPlus { get; set; }
        public List<double> MLess { get; set; }

        public void MClear()
        {
            MPlus = new List<double>();
            MLess = new List<double>();
        }

        public void Clear()
        {
            _answer = 0;
        }

        public double MOutput()
        {
            var mp = MPlus.Sum();
            var ml = MLess.Sum();
            return mp - ml;
        }
        public double Sum(double? Term1, double Term2)
        {
            double answer = (Term1 ?? 0) + Term2;
            _answer = answer;
            _expression = (Term1 == 0 ? "" : Term1.ToString()) + "+" + (Term2 == 0 ? "" : Term2.ToString());
            return answer;

        }
        public double Difference(double? Term1, double Term2)
        {
            double answer = (Term1 ?? 0) - Term2;
            _answer = answer;
            _expression = (Term1 == 0 ? "" : Term1.ToString()) + "-" + (Term2 == 0 ? "" : Term2.ToString());
            return answer;
        }
        public double Product(double? Term1, double Term2)
        {
            double answer = (Term1 ?? 0) * Term2;
            _answer = answer;
            _expression = (Term1 == 0 ? "" : Term1.ToString()) + "x" + (Term2 == 1 ? "" : Term2.ToString());
            return answer;
        }
        public double Quotient(double? Term1, double Term2)
        {
            if (Term2 == 0)
                throw new Exception("Cannot divied by 0");
            double answer = (Term1 ?? 0) / Term2;
            _answer = answer;
            _expression = (Term1 == 0 ? "" : Term1.ToString()) + "÷" + (Term2 == 1 ? "" : Term2.ToString());
            return answer;
        }
        public double SquareRoot(double Term1)
        {
            var answer = Math.Sqrt(Term1);
            _answer = answer;
            _expression = "√" + Term1;
            return answer;
        }
        public double Squared(double Term1)
        {
            var answer = Math.Pow(Term1, 2);
            _answer = answer;
            _expression = Term1 + "²";
            return answer;
        }
        public double Rational(double Term1)
        {
            var answer = 1 / Term1;
            _answer = answer;
            _expression = 1 + "/" + Term1;
            return answer;
            
        }
        public void Equals(double answer)
        {
            _answer = answer;
        }

    }

    public class Output
    {
        public double Answer { get; set; }
        public string Expression { get; set; }
    }
}

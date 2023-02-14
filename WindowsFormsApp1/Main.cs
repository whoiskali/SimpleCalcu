using DevExpress.Utils.Win.Hook;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Main : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        Operation operation = new Operation();
        List<History> Histories = new List<History>();
        double numA = 0;
        double answer = 0;
        double? previewsAnswer;
        double? ans;
        string currentOperator = "";
        OperationEnum? operationEnum;
        
        public Main()
        {
            InitializeComponent();
            lbExpression.Text = "";
            tbAnswer.Text = "0";
            Console.WriteLine(equals.Focus());
            this.ActiveControl = equals;

        }
        bool isValueChanged = false;
        bool isFromEquals = false;
        string expression = "";
        bool isOperation = false; 
        void Compute(OperationEnum _operation)
        {
            var history = new History();
            if(_operation != OperationEnum.Equals && isValueChanged)
            {
                history = new History
                {
                    Hist_Value = numA.ToString(),
                    Hist_Action = _operation,
                    Hist_ID = Histories.Count + 1
                };
                Histories.Add(history);
            }
            try
            {
                previewsAnswer = answer;
                isOperation = true;
                bool done = true;
                Console.WriteLine(operationEnum);
                Console.WriteLine(_operation);
                while (done)
                {
                    switch (operationEnum)
                    {
                        case OperationEnum.Add:
                            done = false;

                            
                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Add)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Sum((double)previewsAnswer, numA);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Add,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.Add && _operation != OperationEnum.Equals)
                            {
                                Console.WriteLine(isFromEquals + " " + numA);
                                if (isFromEquals)
                                {
                                    answer = previewsAnswer == null ? answer : (double)previewsAnswer;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Sum((double)previewsAnswer, numA);
                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Add && isValueChanged)
                                {
                                    answer = previewsAnswer == null ? numA : operation.Sum((double)previewsAnswer, numA);
                                    break;
                                }
                                else
                                {
                                    numA = operation.Sum(answer, 0);

                                }
                            }

                            lbExpression.Text = operation.Expression;
                            break;
                        case OperationEnum.Subtract:
                            //if (!isValueChanged && operation != Operation.Equals)
                            //{
                            //    answer = previewsAnswer ?? 0;
                            //    lbExpression.Text = answer == 0 ? "" : answer + currentOperator;
                            //    break;
                            //}
                            //if (operation == Operation.Subtract && _operation == Operation.Subtract)
                            //{
                            //    if (!isValueChanged)
                            //    {
                            //        answer = (double)previewsAnswer;
                            //        break;
                            //    }
                            //    answer = (previewsAnswer ?? 0) - numA;
                            //    lbExpression.Text = answer + "-";
                            //    numA = answer;
                            //    break;
                            //}

                            //answer = previewsAnswer == null ? numA : (double)previewsAnswer - numA;
                            //lbExpression.Text = previewsAnswer != null ? previewsAnswer + "-" + _numA : answer + "-";

                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Subtract)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Difference((double)previewsAnswer, numA);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Subtract,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.Subtract && _operation != OperationEnum.Equals)
                            {
                                Console.WriteLine(isFromEquals + " " + numA);
                                if (isFromEquals)
                                {
                                    answer = previewsAnswer == null ? answer : (double)previewsAnswer;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Difference((double)previewsAnswer, numA);
                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Subtract && isValueChanged)
                                {
                                    answer = previewsAnswer == null ? numA : operation.Difference((double)previewsAnswer, numA);
                                    break;
                                }
                                else
                                {
                                    numA = operation.Difference(answer, 0);

                                }
                            }

                            break;
                        case OperationEnum.Multiply:


                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Multiply)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Product((double)previewsAnswer, numA);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Multiply,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.Multiply && _operation != OperationEnum.Equals)
                            {
                                Console.WriteLine(isFromEquals + " " + numA);
                                if (isFromEquals)
                                {
                                    answer = previewsAnswer == null ? answer : operation.Product((double)previewsAnswer, 1);
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Product((double)previewsAnswer, numA);
                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Multiply && isValueChanged)
                                {
                                    if (numA != 0)
                                        answer = previewsAnswer == null ? numA : operation.Product((double)previewsAnswer, numA);
                                    else
                                        answer = previewsAnswer == null ? numA : operation.Product((double)previewsAnswer, 1);
                                    break;
                                }
                                else
                                {
                                    numA = operation.Answer;

                                }
                            }

                            break;
                        case OperationEnum.Divide:




                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Divide)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Quotient((double)previewsAnswer, numA);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Divide,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.Divide && _operation != OperationEnum.Equals)
                            {
                                Console.WriteLine(isFromEquals + " " + numA);
                                if (isFromEquals)
                                {
                                    answer = previewsAnswer == null ? answer : operation.Quotient((double)previewsAnswer, 1);
                                }
                                else
                                    answer = previewsAnswer == null ? answer : operation.Quotient((double)previewsAnswer, numA);
                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Divide && isValueChanged)
                                {
                                    if (numA != 0)
                                        answer = previewsAnswer == null ? numA : operation.Quotient((double)previewsAnswer, numA);
                                    else
                                        answer = previewsAnswer == null ? numA : operation.Quotient((double)previewsAnswer, 1);
                                    break;
                                }
                                else
                                {
                                    numA = operation.Answer;

                                }
                            }

                            break;
                        case OperationEnum.SquareRoot:
                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.SquareRoot)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? operation.SquareRoot(answer) : operation.SquareRoot((double)previewsAnswer);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.SquareRoot,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.SquareRoot && _operation != OperationEnum.Equals)
                            {

                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.SquareRoot && isValueChanged)
                                {
                                    answer = previewsAnswer == null || previewsAnswer == 0 ? operation.SquareRoot(numA) : operation.SquareRoot((double)previewsAnswer);
                                    break;
                                }
                                else
                                {
                                    answer = numA = operation.SquareRoot(answer);
                                }
                            }
                            break;
                        case OperationEnum.Squared:

                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Squared)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? operation.Squared(answer) : operation.Squared((double)previewsAnswer);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Squared,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                
                                break;
                            }

                            else if (_operation != OperationEnum.Squared && _operation != OperationEnum.Equals)
                            {

                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Squared && isValueChanged)
                                {
                                    answer = previewsAnswer == null || previewsAnswer == 0 ? operation.Squared(numA) : operation.Squared((double)previewsAnswer);
                                    break;
                                }
                                else
                                {
                                    answer = numA = operation.Squared(answer);
                                }
                            }
                            break;
                        case OperationEnum.Rational:

                            done = false;

                            if (_operation == OperationEnum.Equals)
                            {
                                if (isFromEquals && operationEnum != OperationEnum.Rational)
                                {
                                    isFromEquals = false;
                                }
                                else
                                    answer = previewsAnswer == null ? operation.Rational(answer) : operation.Rational((double)previewsAnswer);
                                history = new History
                                {
                                    Hist_Value = numA.ToString(),
                                    Hist_Action = OperationEnum.Rational,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                history = new History
                                {
                                    Hist_Value = answer.ToString(),
                                    Hist_Action = OperationEnum.Equals,
                                    Hist_ID = Histories.Count + 1
                                };
                                Histories.Add(history);
                                break;
                            }

                            else if (_operation != OperationEnum.Rational && _operation != OperationEnum.Equals)
                            {

                                operationEnum = _operation;
                                numA = 0;
                                done = true;
                            }
                            else
                            {
                                if (_operation == OperationEnum.Rational && isValueChanged)
                                {
                                    answer = previewsAnswer == null || previewsAnswer == 0 ? operation.Rational(numA) : operation.Rational((double)previewsAnswer);
                                    break;
                                }
                                else
                                {
                                    answer = numA = operation.Rational(answer);
                                }
                            }
                            break;
                        default:
                            if (operationEnum == null)
                            {
                                answer = numA;
                                //expression = numA + currentOperator;
                                //if (currentOperator == "√" || currentOperator == "1/x")
                                //    expression = currentOperator + numA;
                                //lbExpression.Text = expression;
                                done = false;
                                break;
                            }
                            //_operation = (Operation)operation;
                            //operation = Operation.Equals;
                            done = true;
                            break;
                    }
                    if (operationEnum == null)
                        expression = numA + currentOperator;
                    else
                        expression = operation.Expression;
                    previewsAnswer = operation.Answer;
                    lbExpression.Text = expression;


                }
                tbAnswer.Text = answer.ToString();
                ans = previewsAnswer;
                isValueChanged = false;
                isFromEquals = false;
                //if (_operation != Operation.Equals)
                //{
                //    operation = _operation;
                //}

            }
            catch (Exception c)
            {
                history = new History
                {
                    Hist_Value = c.Message.ToString(),
                    Hist_Action = (OperationEnum)operationEnum,
                    Hist_ID = Histories.Count + 1
                };
                Histories.Add(history);
                tbAnswer.Text = c.Message;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            isValueChanged = true;
            if(btn.Text == "." && !isOperation)
            {
                expression = numA + btn.Text.ToString();
            }
            else
            {
                if (isOperation)
                {
                    expression = "";
                    isOperation = false;
                }

                if (btn.Text.Equals("+/-"))
                {
                    expression = previewsAnswer == null ? (numA * -1).ToString() : (previewsAnswer * -1).ToString();
                    previewsAnswer = numA = double.Parse(expression == "." ? "0" : expression);
                }
                else if(btn.Text.Equals("Ans"))
                {

                    if (ans != null)
                    {
                        expression = (numA = (double)ans).ToString();
                    }
                }
                else
                {
                    try
                    {
                        expression = (expression == "." ? "0." + btn.Text : expression + btn.Text);
                        numA = double.Parse(expression == "." ? "0" : expression);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot add another dot." + expression);
                        expression = expression.Remove(expression.Length - 2);
                    }   
                }
            }

            tbAnswer.Text = numA.ToString();

            equals.Focus();

        }
        private void operator_Click(object sender, EventArgs e)
        {
            var history = new History();

            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            try
            {
                switch (btn.Text)
                {
                    case "+":
                        currentOperator = "+";
                        Compute(OperationEnum.Add);
                        operationEnum = OperationEnum.Add;
                        break;
                    case "-":
                        currentOperator = "-";
                        Compute(OperationEnum.Subtract);
                        operationEnum = OperationEnum.Subtract;
                        break;
                    case "x":
                        currentOperator = "x";
                        Compute(OperationEnum.Multiply);
                        operationEnum = OperationEnum.Multiply;
                        break;
                    case "÷":
                        currentOperator = "÷";
                        Compute(OperationEnum.Divide);
                        operationEnum = OperationEnum.Divide;
                        break;
                    case "=":
                        currentOperator = "=";
                        Compute(OperationEnum.Equals);
                        isFromEquals = true;
                        break;
                    case "²√x":
                        currentOperator = "√";
                        if (previewsAnswer == null)
                            operationEnum = OperationEnum.SquareRoot;
                        Compute(OperationEnum.SquareRoot);
                        operationEnum = OperationEnum.SquareRoot;
                        break;
                    case "x²":
                        currentOperator = "²";
                        if (previewsAnswer == null)
                            operationEnum = OperationEnum.Squared;
                        Compute(OperationEnum.Squared);
                        operationEnum = OperationEnum.Squared;
                        break;
                    case "1/x":
                        currentOperator = "1/";
                        if (previewsAnswer == null)
                            operationEnum = OperationEnum.Rational;
                        Compute(OperationEnum.Rational);
                        operationEnum = OperationEnum.Rational;
                        break;
                    case "C":
                        numA = 0;
                        isOperation = true;
                        answer = 0;
                        operationEnum = null;
                        tbAnswer.Text = "0";
                        lbExpression.Text = "";
                        previewsAnswer = null;
                        currentOperator = "";
                        operation.Clear();
                        break;
                    case "CE":
                        numA = 0;
                        expression = "0";
                        tbAnswer.Text = "0";
                        break;
                    default:
                        Console.WriteLine(btn.Text);
                        break;
                }
                equals.Focus();
            }
            catch (Exception c)
            {
                history = new History
                {
                    Hist_Value = c.Message,
                    Hist_Action = (OperationEnum)operationEnum,
                    Hist_ID = Histories.Count + 1
                };
                Histories.Add(history);
            }

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            var _numA = numA.ToString();

            if (_numA.Length == 1)
                numA = 0;
            else
                numA = double.Parse(_numA.Remove(_numA.Length - 1));
            expression = numA.ToString();
            tbAnswer.Text = expression;
            equals.Focus();
        }


        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextEdit).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            switch (e.KeyChar)
            {
                case '1':
                    Console.WriteLine("cased");
                    one.PerformClick();
                    break;
                case '2':
                    two.PerformClick();
                    break;
                case '3':
                    three.PerformClick();
                    break;
                case '4':
                    four.PerformClick();
                    break;
                case '5':
                    five.PerformClick();
                    break;
                case '6':
                    six.PerformClick();
                    break;
                case '7':
                    seven.PerformClick();
                    break;
                case '8':
                    eight.PerformClick();
                    break;
                case '9':
                    nine.PerformClick();
                    break;
                case '0':
                    zero.PerformClick();
                    break;
                case '.':
                    dot.PerformClick();
                    break;
                case '+':
                    plus.PerformClick();
                    break;
                case '*':
                    multiply.PerformClick();
                    break;
                case '/':
                    divide.PerformClick();
                    break;
                case '-':
                    minus.PerformClick();
                    break;
                case '=':
                    equals.PerformClick();
                    break;

                default:
                    break;
            }
            equals.Focus();
        }
        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                backspace.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                equals.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                clear.PerformClick();
            }
            Console.WriteLine(equals.Focus());
        }

        List<string> mem = new List<string>();
        private void MPlus_Click(object sender, EventArgs e)
        {
            double value = operation.Answer;
            if (!isFromEquals)
            {
                equals.PerformClick();
                value = operation.Answer;
            }
            else
            {
                if(isValueChanged)
                    value = numA;
            }

            operation.MPlus.Add(value);
            mem.Add("+"+value.ToString());
            if (isHistory)
            {
                lbMemory.Items.Clear();
                foreach (var item in mem)
                {
                    lbMemory.Items.Add(item);
                };
            }
            else
                lbMemory.Items.Add("+"+value);
        }

        private void MLess_Click(object sender, EventArgs e)
        {
            double value = operation.Answer;
            if (!isFromEquals)
            {
                equals.PerformClick();
                value = operation.Answer;
            }
            else
            {
                if (isValueChanged)
                    value = numA;
            }

            operation.MLess.Add(value);
            mem.Add("-" + value.ToString());
            if (isHistory)
            {
                lbMemory.Items.Clear();
                foreach (var item in mem)
                {
                    lbMemory.Items.Add(item);
                };
            }
            else
                lbMemory.Items.Add("-" + value);
        }

        private void mrc_Click(object sender, EventArgs e)
        {
            if (!isFromEquals)
                equals.PerformClick();
            tbAnswer.Text = (previewsAnswer = numA = answer = operation.MOutput()).ToString();
            operation.Equals(previewsAnswer);
        }

        private void mClear_Click(object sender, EventArgs e)
        {
            operation.MClear();
            lbMemory.Items.Clear();
        }
        private void clear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear.PerformClick();
        }

        private void exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string serialized = "";
            using (StringWriter stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(Histories.GetType());
                serializer.Serialize(stringwriter, Histories);
                serialized = stringwriter.ToString();
            }
            XmlDocument xdoc = new XmlDocument();
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = DateTime.Now.ToString();

            save.Filter = "XML File | *.xml";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(serialized);
                writer.Dispose();

                writer.Close();

            }
        }
        bool isHistory = false;
        private void import_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";


            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                XmlSerializer reader = new XmlSerializer(typeof(List<History>));
                StreamReader file = new StreamReader(openFileDialog.FileName);
                List<History> deserialized = (List<History>)reader.Deserialize(file);
                file.Close();

                Histories = deserialized;

            }

            view.PerformClick();
            isHistory = true;
        }

        private void view_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbMemory.Items.Clear();
            lbMemory.Items.Add("ID" + "\t" + "Action" + "\t" + "Value");
            foreach (var item in Histories)
            {
                lbMemory.Items.Add(item.Hist_ID + "\t" + item.Hist_Action + "\t" + item.Hist_Value);
            }

            isHistory = true;
        }

        private void copy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clipboard.SetText(tbAnswer.Text);
        }

        private void paste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                numA = double.Parse(Clipboard.GetText());
                tbAnswer.Text = numA.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect format");
            }
        }
    }
}

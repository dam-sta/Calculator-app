using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string count = "0";
        private string prevCount = "0";
        private string action = "";
        private string nextOperator = "";
        private string[] operators = { "-", "+", "/", "x" };
        private string countBeforeResult = "";
        private string prevOperator, equalsResult;
        private Rectangle originalFormSize, btn1OriginalRectangle, btn2OriginalRectangle, btn3OriginalRectangle, btn4OriginalRectangle, btn5OriginalRectangle, btn6OriginalRectangle, btn7OriginalRectangle, btn8OriginalRectangle, btn9OriginalRectangle, btn0OriginalRectangle, btnminusOriginalRectangle, btnplusOriginalRectangle, btnmultiplicationOriginalRectangle, btndivisionOriginalRectangle, btnequalsOriginalRectangle, btnbackOriginalRectangle, btncommaOriginalRectangle, resultOriginalRectangle, prevCalculationOriginalRectangle, tableOriginalRectangle;

        public void ZeroCountBeforeResult() { prevCalculation.Text = ""; }
        public void OperatorTwoTimesPress(string op)
        {
            if (nextOperator == operators[0])
            {
                count = (double.Parse(prevCount) - double.Parse(count)).ToString();
            }
            else if (nextOperator == operators[1])
            {
                count = (double.Parse(prevCount) + double.Parse(count)).ToString();
            }
            else if (nextOperator == operators[2])
            {
                if (count == "0")
                {
                    result.Text = "nie można dzielić przez zero";
                    prevCalculation.Text = "";
                    prevCount = "0";
                    return;
                }
                else
                {
                    count = (double.Parse(prevCount) / double.Parse(count)).ToString();
                }
            }
            else if (nextOperator == operators[3])
            {
                count = (double.Parse(prevCount) * double.Parse(count)).ToString();
            }
            prevCalculation.Text = ($"{count} {op}");
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result.Text = (count);
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            btn1OriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            btn2OriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            btn3OriginalRectangle = new Rectangle(btn3.Location.X, btn3.Location.Y, btn3.Width, btn3.Height);
            btn4OriginalRectangle = new Rectangle(btn4.Location.X, btn4.Location.Y, btn4.Width, btn4.Height);
            btn5OriginalRectangle = new Rectangle(btn5.Location.X, btn5.Location.Y, btn5.Width, btn5.Height);
            btn6OriginalRectangle = new Rectangle(btn6.Location.X, btn6.Location.Y, btn6.Width, btn6.Height);
            btn7OriginalRectangle = new Rectangle(btn7.Location.X, btn7.Location.Y, btn7.Width, btn7.Height);
            btn8OriginalRectangle = new Rectangle(btn8.Location.X, btn8.Location.Y, btn8.Width, btn8.Height);
            btn9OriginalRectangle = new Rectangle(btn9.Location.X, btn9.Location.Y, btn9.Width, btn9.Height);
            btn0OriginalRectangle = new Rectangle(btn0.Location.X, btn0.Location.Y, btn0.Width, btn0.Height);
            btncommaOriginalRectangle = new Rectangle(buttoncomma.Location.X, buttoncomma.Location.Y, buttoncomma.Width, buttoncomma.Height);
            btnbackOriginalRectangle = new Rectangle(btnback.Location.X, btnback.Location.Y, btnback.Width, btnback.Height);
            btnminusOriginalRectangle = new Rectangle(btnminus.Location.X, btnminus.Location.Y, btnminus.Width, btnminus.Height);
            btnplusOriginalRectangle = new Rectangle(btnplus.Location.X, btnplus.Location.Y, btnplus.Width, btnplus.Height);
            btnmultiplicationOriginalRectangle = new Rectangle(btnmultiplication.Location.X, btnmultiplication.Location.Y, btnmultiplication.Width, btnmultiplication.Height);
            btndivisionOriginalRectangle = new Rectangle(btndivision.Location.X, btndivision.Location.Y, btndivision.Width, btndivision.Height);
            btnequalsOriginalRectangle = new Rectangle(btnequals.Location.X, btnequals.Location.Y, btnequals.Width, btnequals.Height);
            resultOriginalRectangle = new Rectangle(result.Location.X, result.Location.Y, result.Width, result.Height);
            prevCalculationOriginalRectangle = new Rectangle(prevCalculation.Location.X, prevCalculation.Location.Y, prevCalculation.Width, prevCalculation.Height);
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void FormResize(object sender, EventArgs e)
        {
            ResizeControl(btn1OriginalRectangle, button1);
            ResizeControl(btn2OriginalRectangle, button2);
            ResizeControl(btn3OriginalRectangle, btn3);
            ResizeControl(btn4OriginalRectangle, btn4);
            ResizeControl(btn5OriginalRectangle, btn5);
            ResizeControl(btn6OriginalRectangle, btn6);
            ResizeControl(btn7OriginalRectangle, btn7);
            ResizeControl(btn8OriginalRectangle, btn8);
            ResizeControl(btn9OriginalRectangle, btn9);
            ResizeControl(btn0OriginalRectangle, btn0);
            ResizeControl(btncommaOriginalRectangle, buttoncomma);
            ResizeControl(btnbackOriginalRectangle, btnback);
            ResizeControl(btnminusOriginalRectangle, btnminus);
            ResizeControl(btnplusOriginalRectangle, btnplus);
            ResizeControl(btnmultiplicationOriginalRectangle, btnmultiplication);
            ResizeControl(btndivisionOriginalRectangle, btndivision);
            ResizeControl(btnequalsOriginalRectangle, btnequals);
            ResizeControl(resultOriginalRectangle, result);
            ResizeControl(prevCalculationOriginalRectangle, prevCalculation);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn1(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "1";
            }
            else
            {
                count = "1";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn2(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "2";
            }
            else
            {
                count = "2";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn3(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "3";
            }
            else
            {
                count = "3";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn4(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "4";
            }
            else
            {
                count = "4";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn5(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "5";
            }
            else
            {
                count = "5";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn6(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "6";
            }
            else
            {
                count = "6";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn7(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "7";
            }
            else
            {
                count = "7";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn8(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "8";
            }
            else
            {
                count = "8";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn9(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "9";
            }
            else
            {
                count = "9";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btn0(object sender, EventArgs e)
        {
            if (count != "0" && action != "=")
            {
                count += "0";
            }
            else
            {
                count = "0";
                if (action == "=" && nextOperator == "")
                {
                    ZeroCountBeforeResult();
                    prevCount = "0";
                }
                action = "";
            }
            result.Text = (count);
        }

        private void Btnback(object sender, EventArgs e)
        {
            if (count.Length != 0 && count.Length != 1 && action != "=")
            {
                count = count.Substring(0, count.Length - 1);
            }
            else if (action == "=" && nextOperator == "")
            {
                prevCount = "0";
                count = "0";
                ZeroCountBeforeResult();
            }
            else
            {
                count = "0";
            }
            result.Text = (count);
        }

        private void Btnminus(object sender, EventArgs e)
        {
            if (count != "0")
            {
                if (nextOperator != "")
                {
                    OperatorTwoTimesPress("-");
                }
                prevCount = count;
            }
            count = "0";
            prevCalculation.Text = $"{prevCount} -";
            result.Text = (count);
            nextOperator = "-";
        }

        private void Btnplus(object sender, EventArgs e)
        {
            if (count != "0")
            {
                if (nextOperator != "")
                {
                    OperatorTwoTimesPress("+");
                }
                prevCount = count;
            }
            count = "0";
            prevCalculation.Text = $"{prevCount} +";
            result.Text = (count);
            nextOperator = "+";
        }

        private void Btnmultiplication(object sender, EventArgs e)
        {
            if (count != "0")
            {
                if (nextOperator != "")
                {
                    OperatorTwoTimesPress("x");
                }
                prevCount = count;
            }
            count = "0";
            prevCalculation.Text = $"{prevCount} x";
            result.Text = (count);
            nextOperator = "x";
        }

        private void Btndivision(object sender, EventArgs e)
        {
            if (count != "0")
            {
                if (nextOperator != "")
                {
                    OperatorTwoTimesPress("/");
                }
                prevCount = count;
            }
            count = "0";
            prevCalculation.Text = $"{prevCount} /";
            result.Text = (count);
            nextOperator = "/";
        }

        private void Btncomma(object sender, EventArgs e)
        {
            if (!count.Contains(","))
            {
                if (action == "=" && nextOperator == "")
                {
                    count = "0";
                    action = "";
                    prevCount = "0";
                    ZeroCountBeforeResult();
                }
                count = string.Concat(count + ",");
                result.Text = count;
            }
            else if (prevCalculation.Text.Contains("="))
            {
                count = "0";
                action = "";
                prevCount = "0";
                ZeroCountBeforeResult();
                count = string.Concat(count + ",");
                result.Text = count;
            }
        }


        private void Btnequals(object sender, EventArgs e)
        {
            if (nextOperator == operators[0])
            {
                countBeforeResult = count;
                count = (double.Parse(prevCount) - double.Parse(count)).ToString();
            }
            else if (nextOperator == operators[1])
            {
                countBeforeResult = count;
                count = (double.Parse(prevCount) + double.Parse(count)).ToString();
            }
            else if (nextOperator == operators[2])
            {
                if (count == "0")
                {
                    result.Text = "nie można dzielić przez zero";
                    prevCalculation.Text = "";
                    prevCount = "0";
                    return;
                }
                else
                {
                    countBeforeResult = count;
                    count = (double.Parse(prevCount) / double.Parse(count)).ToString();
                }
            }
            else if (nextOperator == operators[3])
            {
                countBeforeResult = count;
                count = (double.Parse(prevCount) * double.Parse(count)).ToString();
            }
            result.Text = (count);

            if (nextOperator != "")
            {
                prevCalculation.Text = (prevCount + " " + nextOperator + " " + countBeforeResult + " =");
                prevOperator = nextOperator;
            }
            else if (prevCount == "0")
            {
                prevCalculation.Text = (count + " =");
            }
            else
            {
                if (prevOperator == operators[0])
                {
                    equalsResult = count;
                    count = (double.Parse(count) - double.Parse(countBeforeResult)).ToString();
                }
                else if (prevOperator == operators[1])
                {
                    equalsResult = count;
                    count = (double.Parse(count) + double.Parse(countBeforeResult)).ToString();
                }
                else if (prevOperator == operators[2])
                {
                    equalsResult = count;
                    count = (double.Parse(count) / double.Parse(countBeforeResult)).ToString();
                }
                else if (prevOperator == operators[3])
                {
                    equalsResult = count;
                    count = (double.Parse(count) * double.Parse(countBeforeResult)).ToString();
                }
                result.Text = (count);
                prevCalculation.Text = ($"{equalsResult} {prevOperator} {countBeforeResult} =");
            }
            nextOperator = "";
            action = "=";
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            prevCalculation.Location = new Point(Convert.ToInt16(Convert.ToDouble(this.Width) - Convert.ToDouble(prevCalculation.Width) - Convert.ToDouble(this.Width) * 0.1), 10);
        }

        private void KeyPressForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                Btn1(sender, e);
            }
            if (e.KeyChar == (char)Keys.D2)
            {
                Btn2(sender, e);
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                Btn3(sender, e);
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                Btn4(sender, e);
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                Btn5(sender, e);
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                Btn6(sender, e);
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                Btn7(sender, e);
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                Btn8(sender, e);
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                Btn9(sender, e);
            }
            if (e.KeyChar == (char)Keys.D0)
            {
                Btn0(sender, e);
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                Btnback(sender, e);
            }
            if (e.KeyChar == '=')
            {
                Btnequals(sender, e);
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                Btncomma(sender, e);
            }
            if (e.KeyChar == '-')
            {
                Btnminus(sender, e);
            }
            if (e.KeyChar == '+')
            {
                Btnplus(sender, e);
            }
            if (e.KeyChar == '/')
            {
                Btndivision(sender, e);
            }
            if (e.KeyChar == '*' || e.KeyChar == 'x')
            {
                Btnmultiplication(sender, e);
            }
        }

        private void prevCalculation_Click(object sender, EventArgs e)
        {

        }
    }
}

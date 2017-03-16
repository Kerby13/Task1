using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

namespace LatestTest
{
    class StringCalculator : IMathCalculator<string>
    {
        public string Add(string n1, string n2)
        {
            return n1 + n2;
        }

        public string Div(string n1, string n2)
        {
            throw new WrongOperationException("Нельзя это делать со строками, ну!111!11кек");
        }

        public string Mul(string n1, string n2)
        {
            throw new WrongOperationException("Нельзя это делать со строками, ну!111!11кек");
        }

        public string Sub(string n1, string n2)
        {
            throw new WrongOperationException("Нельзя это делать со строками, ну!111!11кек");
        }
    }
}

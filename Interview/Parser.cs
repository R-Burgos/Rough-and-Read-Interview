using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Parser
    {
        public IQandA Parse(string line)
        {
            var cells = line.Split(',');
            var question = cells[0];
            var answer = cells[1];

            var qANDa = new QandA();
            qANDa.Question = question.ToString();
            qANDa.Answer = answer.ToString();
            Console.WriteLine(qANDa.Question);
            Console.ReadLine();
            Console.WriteLine(qANDa.Answer);
            Console.ReadLine();
            Console.WriteLine("*--------------------------------------------------------------------------------------------------------*");

            return qANDa;
        }



    }
}

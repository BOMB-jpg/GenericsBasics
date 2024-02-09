using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Salaries salaries = new Salaries();

            // ArrayList salaryList = salaries.GetSalaries();
            List<float> salaryList = salaries.GetSalaries(); //列表的实例
            
            float salary = salaryList[1];

            salary = salary + (salary * 0.02f);

            Console.WriteLine(salary);

            Console.ReadKey();


        }
    }

    public class Salaries
    {
        //ArrayList _salaryList = new ArrayList();
        //List<float>类型的字段 存储工资
        List<float> _salaryList = new List<float>();
        //构造放啊
        public Salaries()
        {
            /*_salaryList.Add(60000.34);
            _salaryList.Add(40000.51);
            _salaryList.Add(20000.23);*/

            _salaryList.Add(60000.34f);
            _salaryList.Add(40000.51f);
            _salaryList.Add(20000.23f);

        }

       // public ArrayList GetSalaries()
        public List<float> GetSalaries()
        {
            return _salaryList;
        }

    }
}

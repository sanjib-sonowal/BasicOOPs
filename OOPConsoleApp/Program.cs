using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VALUE & REFERENCE TYPE TEST

            Console.WriteLine("VALUE & REFERENCE TYPE TEST");
            Console.WriteLine("=======================>>>");
            ValueAndReferenceTypes.ValueTypeTest();
            ValueAndReferenceTypes.ReferenceTypeTest();
            Console.WriteLine("*************************************************\n");

            #endregion

            #region INHERITENCE TEST

            Console.WriteLine("INHERITENCE TEST");
            Console.WriteLine("=======================>>>");
            Child C1 = new Child();
            C1.Write();
            //Type caste C1 to be of type Parent and call Write () method
            ((Parent)C1).Write();
            Console.WriteLine("*************************************************\n");

            #endregion

            #region POLYMORPHISM TEST

            Console.WriteLine("POLYMORPHISM TEST");
            Console.WriteLine("=======================>>>");
            Console.WriteLine("FUNCTION OVERLOADING -> Static Binding");
            Print p1 = new Print();
            p1.display("Sanjib Sonowal");
            p1.display("Olga", 19);

            Shape ob = new Shape();
            ob.Area(2.0f);
            ob.Area(20.0f, 30.0f);
            ob.Area(2.0f, 3.0f, 4.0f);
            Console.WriteLine("\n=======================>>>");
            Console.WriteLine("FUNCTION OVERRDING -> Dynamic Binding");
            DerivedClass objDC = new DerivedClass();
            objDC.Function1();
            BaseClass objBC = (BaseClass)objDC;
            objDC.Function1();
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region MULTIPLE INHERITENCE USING INTERFACE

            Console.WriteLine("MULTIPLE INHERITENCE TEST");
            Console.WriteLine("=======================>>>");
            Console.WriteLine("Multiple inheritance using interface\n ");
            OperMultipleInheritenceations obj = new OperMultipleInheritenceations();
            Console.WriteLine("Result1: " + obj.Function1(20, 10));
            Console.WriteLine("Result2: " + obj.Function2(100, 50));
            Console.WriteLine("Result3: " + obj.Function3(30, 3));
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region REF & OUT

            Console.WriteLine("REF TEST");
            Console.WriteLine("=======================>>>");
            int refVal = 3; // Variable need to be initialized.
            RefOutParams.RefSample(ref refVal);
            Console.WriteLine(refVal);
            Console.WriteLine("\n");
            Console.WriteLine("OUT TEST");
            Console.WriteLine("=======================>>>");
            int value;
            RefOutParams.OutSample(5, 5, out value);
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region HASHTABLE & DICTIONARY

            Console.WriteLine("HASHTABLE TEST");
            Console.WriteLine("=======================>>>");
            DictonaryAndHashtable dh = new DictonaryAndHashtable();
            dh.HashtableTest();
            Console.WriteLine("DICTIONARY TEST");
            Console.WriteLine("=======================>>>");
            dh.DictionaryTest();
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region COPY CONSTRUCTOR

            Console.WriteLine("COPY CONSTRUCTOR TEST");
            Console.WriteLine("=======================>>>");
            CopyConstructor cpobj = new CopyConstructor("Hello!", "Sanjib");
            CopyConstructor cp1Obj = new CopyConstructor(cpobj);
            Console.WriteLine("Object-1 value " + cpobj.abc + " " + cpobj.xyz + " copied to Object-2 with same value " + cp1Obj.abc + " " + cp1Obj.xyz);
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region STATIC CONSTRUCTOR

            Console.WriteLine("STATIC CONSTRUCTOR TEST");
            Console.WriteLine("=======================>>>");
            Console.WriteLine("First Instance Calls Both The Constructors.");
            StaticConstructor staticObj = new StaticConstructor();
            Console.WriteLine(staticObj.abc + " " + staticObj.xyz);
            Console.WriteLine("\n");
            Console.WriteLine("Second Instance Calls Only The Default Constructors.");
            StaticConstructor staticObj1 = new StaticConstructor();
            Console.WriteLine(staticObj1.abc + " " + staticObj1.xyz);
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region DELEGATES

            Console.WriteLine("DELEGATES TEST");
            Console.WriteLine("=======================>>>");
            Delegates delegateObj = new Delegates();
            //MathDelegate delegate1 = new MathDelegate(delegateObj.Add); /* Can be used for single function */
            //int addVal = delegate1(100, 50);
            //Console.WriteLine("Delegate Add Function Value : " + addVal);
            MathDelegate delegate1 = delegateObj.Add;
            delegate1 += delegateObj.Sub;
            delegate1 += delegateObj.Mul;
            delegate1 += delegateObj.Div;
            delegate1 += delegateObj.Mod;
            delegate1(100, 50);
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region DELEGATES REAL SCENARIO

            Console.WriteLine("DELEGATES REAL SCENARIO TEST");
            Console.WriteLine("=======================>>>");
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 1, Name = "Bruce Wayne", Salary = 10000, Experience = 10 });
            empList.Add(new Employee() { Id = 2, Name = "Clark Kent", Salary = 8000, Experience = 8 });
            empList.Add(new Employee() { Id = 3, Name = "Tony Stark", Salary = 9000, Experience = 7 });
            empList.Add(new Employee() { Id = 3, Name = "Jimmy Page", Salary = 4000, Experience = 4 });

            // Create the delegate object and pass in the function that has the logic for promote.
            //IsPromotable isPrmomotable = new IsPromotable(Promote);
            //Employee.Promote(empList, isPrmomotable);

            Employee.Promote(empList, emp => emp.Experience >= 5); // Without using the above code and by passing lambda expression. 
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region CUSTOM EXCEPTIONS

            Console.WriteLine("CUSTOM EXCEPTION TEST");
            Console.WriteLine("=======================>>>");
            int i = 7;
            if(i < 10)
            {
                //throw new CustomExceptions();
            }
            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region GENERIC TYPES

            Console.WriteLine("GENERIC TYPES");
            Console.WriteLine("=======================>>>");

            // Example-1 : Generic Method
            Console.WriteLine(GenericType1.IsEqual<int>(10, 10));
            Console.WriteLine(GenericType1.IsEqual<string>("ABC", "ABC"));
            // Example-2 : Generic Class
            Console.WriteLine(GenericType2<int>.IsEqual(10, 10));
            Console.WriteLine(GenericType2<string>.IsEqual("ABC", "ABC"));

            Console.WriteLine("\n*************************************************\n");

            #endregion

            #region LOOP A DICTIONARY

            Console.WriteLine("LOOP DICTIONARY");
            Console.WriteLine("=======================>>>");

            Dictionary.LoopDictionary();

            Console.WriteLine("\n*************************************************\n");

            #endregion

            /* STOPS AUTOMATICALLY EXIT */
            Console.ReadLine();
        }

        /// <summary>
        /// TESTING METHOD FOR DELEGATES IN REAL LIFE SCENARIO. 
        /// **THIS METHOD CAN ALSO BE REPLACE BY LAMBDA EXPRESSION IN CALLING PROGRAM.**
        /// </summary>
        /// <returns></returns>
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }

            return false;
        }
    }
}

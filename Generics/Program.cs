using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //MyGenericClass is a Generic Class
    class GenericClass<T>
    {
        //Generic variable
        //The data type is generic
        private T genericMemberVariable;
        //Generic Constructor
        //Constructor accepts one parameter of Generic type
        public GenericClass(T value)
        {
            genericMemberVariable = value;
        }
        //Generic Method
        //Method accepts one Generic type Parameter
        //Method return type also Generic
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
        //Generic Property
        //The data type is generic
        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //GenericClass<int> integerGenericClass = new GenericClass<int>(10);
            //int val = integerGenericClass.genericMethod(200);
           

          //  At the time of instantiation, we can use any type as per our requirement.
          //  If we want to use a string type, then we need to instantiate the class as shown below

            GenericClass<string> stringGenericClass = new GenericClass<string>("Hello Generic World");
            stringGenericClass.genericProperty = "This is a generic property example.";
            string result = stringGenericClass.genericMethod("Generic Parameter");
            
        }
    }
}

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region old code

            #endregion

            #region Q1

            // a) What happens when you assign one object variable to another object variable?
            // the two variables will refer to the same ref. in the memory (copy ref.) , new object is created

            // b) Does assigning one object to another create a new object? Explain.
            // No , both of them will be share the same ref. in the memory , if you change one of them , both will be affected

            // c) What is the difference between copying an object and copying its reference?
            // object => new object created in the memory with the same data
            // ref. => only copy the ref. in the memory (no new object)

            #endregion

            #region Q2

            // a) What is a Shallow Copy?
            // create a new object and copies all value types , nested objects only copies the ref.

            // b) What is a Deep Copy?
            // create a new object and copies all value types , nested objects (original and copy are independent)

            // c) What happens to reference-type members when a Shallow Copy is created?
            // they share the same ref. ,if you change one of them both will be affected

            // d) What happens to reference-type members when a Deep Copy is created?
            // original and copy are independent كل واحدة بتشاور على مكان لو غيرت في واحدة مش هيتأثر التاني

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // if the business case require an isolation between objects

            #endregion

            #region Q3

            // a) What is a static field, and how is it different from an instance field ?
            // static field is shared by all classes , you cannot access instance field within a static ,static field created once (العكس لل instance بس يقدر يوصل لل static , instance members)

            // b) What is a static method? Can a static method directly access instance members? 
            // static method belongs to the class and cannot access instance members directly

            // c) What is a static constructor, and when is it executed?
            // static ctor => used to intialize static member , executes at runtime (it happens first)

            // d) What is a static class? Can you create an object from a static class?
            // this class contain only static members ,you cannot create an object from it


            #endregion

            #region Q4

            // a) What is an Extension Method?
            // method for extending and adding a new methods to an existing type without any modifications in the old code

            // b) What keyword must be used in the first parameter of an extension method?
            // (this)

            // c) Where must an extension method be declared?
            // inside the static class

            // d) Can an extension method access private members of the class it extends?
            // no

            #endregion

            #region Q5

            // a) What is a Partial Class?
            // many classes that must use (partial) key word and the same namespace , they are combined at the run time

            // b) Why would a developer split one class into multiple files?
            // improve readability , organize large classes

            // c) What is a Partial Method?
            // method without an implementation,it can be optionally implemented in other class

            // d) What happens if a declared partial method has no implementation?
            // the compiler removes any calls of it

            #endregion

            #region Q6.1

            //StandardShipment s1 = new StandardShipment("jl555", "laptop", 656, 52.5m, new DeliveryAddress("giza", "zayed", 111));
            //StandardShipment s2 = s1;
            //s1.PrintShipment();
            //Console.WriteLine("______________________________");
            //s2.PrintShipment();

            #endregion

            #region Q6.2

            //StandardShipment s3 = new StandardShipment("jl555", "laptop", 656, 52.5m, new DeliveryAddress("giza", "zayed", 111));
            //StandardShipment copy=(StandardShipment)s3.ShallowCopy();
            //copy.Destination.GetCity = "Cairo";
            //s3.PrintShipment();
            //Console.WriteLine("______________________________");
            //copy.PrintShipment();
            //Console.WriteLine(object.ReferenceEquals(s3, copy));

            #endregion

            #region Q6.3

            //StandardShipment original = new StandardShipment("SH9001", "Laptop", 2.5, 100m, new DeliveryAddress("Cairo", "Tahrir", 10));
            //StandardShipment copied = (StandardShipment)original.DeepCopy();
            //copied.Destination.GetCity = "fayoum";
            //Console.WriteLine(object.ReferenceEquals(original.Destination, copied.Destination));
            //Console.WriteLine(object.ReferenceEquals(original, copied));
            //original.PrintShipment();
            //copied.PrintShipment();

            #endregion

            #region Q6.4

            // static field

            #endregion

            #region Q6.5

            // Console.WriteLine(Shipment.TotalShipmentsCreated);

            #endregion

            #region Q6.6

            // 5 Static Constructor

            #endregion

            #region Q6.7

            // static class

            #endregion
        }
    }
}

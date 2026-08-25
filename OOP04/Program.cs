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
        }
    }
}

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
        }
    }
}

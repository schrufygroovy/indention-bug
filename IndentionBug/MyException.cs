namespace IndentionBug
{
    public class MyException : DivideByZeroException
    {
        public MyException()
            : base()
        {
        }

        public MyException(string? message)
        // this should fail the build because indention is not multiple of 4
              : base(message)
        {
        }

        public MyException(string? message, Exception? innerException)
        // this should fail the build because indention is not multiple of 4
  : base(message, innerException)
        {
        }
    }
}
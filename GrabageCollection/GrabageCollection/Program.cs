namespace GrabageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000000; i++)
            {
                Class1 obj1 = new Class1();
                obj1.Dispose();
                Class2 obj2 = new Class2();
                obj2.Dispose();
                Class3 obj3 = new Class3();
                obj3.Dispose();
            }
        }
    }

    public class Class1:IDisposable
    {
        private bool disposedValue=false;//To detect redudant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //dispose managed state objects
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            //GC.SuppressFinalize(this);
        }
        ~Class1()
        {
            Dispose(false);
        }
    }
    public class Class2
    {
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //dispose managed state objects
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        ~Class2()
        {
            Dispose(false);
        }
    }
    public class Class3
    {
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //dispose managed state objects
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        ~Class3()
        {
            Dispose(false);
        }
    }
}
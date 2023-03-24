namespace OrderProcess.classes
{
    public class BaseClassDemo
    {
    }

    public abstract class RepositoryBase
    {
        public virtual bool IsServiceConnectionValid()
        {
            //
            return true;
        }
    }
    public class AuthRepositorty : RepositoryBase { 
        public void Save()
        {
            if (IsServiceConnectionValid())
            {
                //
            }
        }
    }
}

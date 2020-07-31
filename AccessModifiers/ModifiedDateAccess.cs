using DemoLibrary;

namespace AccessModifiers
{
    public class ModifiedDateAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
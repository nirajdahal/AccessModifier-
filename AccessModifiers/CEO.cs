using DemoLibrary;

namespace AccessModifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDateAccess modifiedData = new ModifiedDateAccess();
            modifiedData.GetUnsecureConnectionInfo();
            
        }

    }
}
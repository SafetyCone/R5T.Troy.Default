using System;using R5T.T0064;


namespace R5T.Troy.Default
{[ServiceImplementationMarker]
    public class TemporaryDirectoryNameConvention : ITemporaryDirectoryNameConvention,IServiceImplementation
    {
        public const string TemporaryDirectoryName = "Temp";


        public string GetTemporaryDirectoryName()
        {
            return TemporaryDirectoryNameConvention.TemporaryDirectoryName;
        }
    }
}

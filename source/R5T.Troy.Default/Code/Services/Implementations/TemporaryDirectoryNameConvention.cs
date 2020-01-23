using System;


namespace R5T.Troy.Default
{
    public class TemporaryDirectoryNameConvention : ITemporaryDirectoryNameConvention
    {
        public const string TemporaryDirectoryName = "Temp";


        public string GetTemporaryDirectoryName()
        {
            return TemporaryDirectoryNameConvention.TemporaryDirectoryName;
        }
    }
}

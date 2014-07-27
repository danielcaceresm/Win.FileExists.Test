using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace FileIOTest.Test
{
    public class StorageFolderGetFileAsyncTester : IFileTester
    {
        private readonly StorageFolder root = ApplicationData.Current.LocalFolder;

        public async Task<bool> FileExistsAsync(string filename)
        {
            try
            {
                StorageFile file = await root.GetFileAsync(filename);
                return file != null;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
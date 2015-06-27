using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace FileIOTest.Test
{
    public class StorageFileGetFileFromApplicationUriAsyncTester : IFileTester
    {
        public async Task<bool> FileExistsAsync(string filename)
        {
            try
            {
                Uri appUri = new Uri("ms-appdata:///local/" + filename);
                StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(appUri).AsTask().ConfigureAwait(false);
                return file != null;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
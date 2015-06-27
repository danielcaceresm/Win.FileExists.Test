using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace FileIOTest.Test
{
    public class StorageFolderTryGetItemAsyncTester : IFileTester
    {
        private readonly StorageFolder root = ApplicationData.Current.LocalFolder;

        public async Task<bool> FileExistsAsync(string filename)
        {
            StorageFile file = await root.TryGetItemAsync(filename).AsTask().ConfigureAwait(false) as StorageFile;
            return file != null;
        }
    }
}
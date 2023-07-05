using System;
namespace ex27
{
	public class FileCopy
	{
		string srcPath;
		string destPath;
        DelegateProc? callbackProc;

        public FileCopy()
		{
			srcPath = string.Empty;
			destPath = string.Empty;
            callbackProc = null;
        }

		public async Task StartCopy(string src, string dest, DelegateProc callbackProc)
		{
            await CopyProgress(src, dest, callbackProc);
        }

        private async Task CopyProgress(string srcFile, string destFile, DelegateProc callbackProc)
		{
            FileInfo fileInfo = new FileInfo(srcFile);
            if (!fileInfo.Exists)
                return;

            long totalBytes = fileInfo.Length;

            using (FileStream srcFileStream = new FileStream(srcFile, FileMode.Open))
            {
                using (FileStream destFileStream = new FileStream(destFile, FileMode.Create))
                {
                    int bufferSize = 8192;
                    byte[] buffer = new byte[bufferSize];

                    int bytesRead;
                    int offset = 0;
                    while ((bytesRead = await srcFileStream.ReadAsync(buffer, 0, bufferSize)) > 0)
                    {
                        destFileStream.Write(buffer, 0, bytesRead);
                        offset += bytesRead;
                        if (callbackProc != null)
                            callbackProc(offset, totalBytes);

                        Thread.Sleep(1);
                    }
                }
            }            
        }

    }
}


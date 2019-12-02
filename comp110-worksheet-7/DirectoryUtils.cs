﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_7
{
	public static class DirectoryUtils
	{
		// Return the size, in bytes, of the given file
		public static long GetFileSize(string filePath)
		{
			return new FileInfo(filePath).Length;
		}

		// Return true if the given path points to a directory, false if it points to a file
		public static bool IsDirectory(string path)
		{
			return File.GetAttributes(path).HasFlag(FileAttributes.Directory);
		}

		// Return the total size, in bytes, of all the files below the given director
		public static long GetTotalSize(string directory)
		{
            string[] sizeOfDirectory = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

            long totalSize = 0;

            foreach (string file in sizeOfDirectory)
            {

                totalSize = GetFileSize(file);

            }

            return totalSize;
		}

		// Return the number of files (not counting directories) below the given directory
		public static int CountFiles(string directory)
		{

            string[] receiveDirectory = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

            return receiveDirectory.Length;
        }

		// Return the nesting depth of the given directory. A directory containing only files (no subdirectories) has a depth of 0
		public static int GetDepth(string directory)
		{
            throw new NotImplementedException();
		}

		// Get the path and size (in bytes) of the smallest file below the given directory
		public static Tuple<string, long> GetSmallestFile(string directory)
		{
			throw new NotImplementedException();
		}

		// Get the path and size (in bytes) of the largest file below the given directory
		public static Tuple<string, long> GetLargestFile(string directory)
		{
			throw new NotImplementedException();
		}

		// Get all files whose size is equal to the given value (in bytes) below the given directory
		public static IEnumerable<string> GetFilesOfSize(string directory, long size)
		{
			throw new NotImplementedException();
		}
	}
}

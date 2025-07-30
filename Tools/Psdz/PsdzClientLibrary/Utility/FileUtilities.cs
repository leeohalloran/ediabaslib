﻿using System;
using System.IO;

namespace PsdzClient.Utility
{
    public static class FileUtilities
    {
        public static string NormalizePath(string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    return null;
                }

                return Path.GetFullPath(new Uri(path).LocalPath)
                    .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                    .ToUpperInvariant();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool PathStartWith(string fullPath, string subPath)
        {
            try
            {
                string fullPathNorm = NormalizePath(fullPath);
                string subPathNorm = NormalizePath(subPath);
                if (string.IsNullOrEmpty(fullPathNorm) || string.IsNullOrEmpty(subPathNorm))
                {
                    return false;
                }

                if (fullPathNorm.IndexOf(subPathNorm, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return false;
        }
    }
}

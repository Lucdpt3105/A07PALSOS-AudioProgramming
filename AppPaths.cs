using System;
using System.IO;
using System.Windows.Forms;

namespace A07PALSOS
{
    internal static class AppPaths
    {
        private const string AudioFolderName = "FileAmThanh";
        private const string DataFolderName = "Data";

        public static string AudioDirectory
        {
            get
            {
                string outputAudioDirectory = Path.Combine(Application.StartupPath, AudioFolderName);
                if (Directory.Exists(outputAudioDirectory))
                {
                    return outputAudioDirectory;
                }

                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);
                for (int i = 0; i < 5 && directory != null; i++)
                {
                    string candidate = Path.Combine(directory.FullName, AudioFolderName);
                    if (Directory.Exists(candidate))
                    {
                        return candidate;
                    }

                    directory = directory.Parent;
                }

                Directory.CreateDirectory(outputAudioDirectory);
                return outputAudioDirectory;
            }
        }

        public static string DataDirectory
        {
            get
            {
                return Path.Combine(Application.StartupPath, DataFolderName);
            }
        }

        public static string ResolveAudioFile(string storedPath, string fileName)
        {
            if (!string.IsNullOrWhiteSpace(storedPath) && Path.IsPathRooted(storedPath) && File.Exists(storedPath))
            {
                return storedPath;
            }

            string resolvedName = !string.IsNullOrWhiteSpace(fileName) ? fileName : storedPath;
            if (string.IsNullOrWhiteSpace(resolvedName))
            {
                return string.Empty;
            }

            return Path.Combine(AudioDirectory, Path.GetFileName(resolvedName));
        }

        public static bool IsSupportedAudioFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();
            return extension == ".mp3" || extension == ".wav" || extension == ".wma" || extension == ".flac" || extension == ".ogg";
        }
    }
}

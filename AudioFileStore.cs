using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A07PALSOS
{
    internal static class AudioFileStore
    {
        private static readonly string StorePath = Path.Combine(AppPaths.DataDirectory, "AudioFiles.xml");

        public static string OpenFileFilter
        {
            get
            {
                return "Audio files (*.mp3;*.wav;*.wma;*.flac;*.ogg)|*.mp3;*.wav;*.wma;*.flac;*.ogg|All files (*.*)|*.*";
            }
        }

        public static void Load(A07PALSOSDataSet dataSet)
        {
            dataSet.AUDIOFILES.Clear();

            if (File.Exists(StorePath))
            {
                dataSet.ReadXml(StorePath);
                NormalizePaths(dataSet);
            }

            if (dataSet.AUDIOFILES.Count == 0)
            {
                SeedFromAudioDirectory(dataSet);
                Save(dataSet);
            }
        }

        public static void Save(A07PALSOSDataSet dataSet)
        {
            Directory.CreateDirectory(AppPaths.DataDirectory);
            dataSet.WriteXml(StorePath, System.Data.XmlWriteMode.WriteSchema);
            dataSet.AcceptChanges();
        }

        public static void AddAudioFile(A07PALSOSDataSet dataSet, string ms, string fileName, string filePath, string description)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            int sizeKb = fileInfo.Exists ? Convert.ToInt32(Math.Max(1, fileInfo.Length / 1024)) : 0;
            string extension = Path.GetExtension(fileName);

            string audioId = string.IsNullOrWhiteSpace(ms) ? GenerateNextId(dataSet) : ms.Trim();
            A07PALSOSDataSet.AUDIOFILESRow existingRow = dataSet.AUDIOFILES.FindByms(audioId);
            if (existingRow == null)
            {
                dataSet.AUDIOFILES.AddAUDIOFILESRow(audioId, fileName, filePath, sizeKb, extension, 0, description);
            }
            else
            {
                existingRow.filename = fileName;
                existingRow.filepath = filePath;
                existingRow.size = sizeKb;
                existingRow.ext = extension;
                existingRow.description = description;
            }

            Save(dataSet);
        }

        public static int ImportAudioFiles(A07PALSOSDataSet dataSet, IEnumerable<string> sourceFiles)
        {
            Directory.CreateDirectory(AppPaths.AudioDirectory);
            int importedCount = 0;

            foreach (string sourceFile in sourceFiles.Where(AppPaths.IsSupportedAudioFile))
            {
                if (!File.Exists(sourceFile))
                {
                    continue;
                }

                string destinationPath = CreateUniqueDestinationPath(Path.GetFileName(sourceFile));
                File.Copy(sourceFile, destinationPath, false);
                AddAudioRow(dataSet, GenerateNextId(dataSet), Path.GetFileName(destinationPath), destinationPath);
                importedCount++;
            }

            if (importedCount > 0)
            {
                Save(dataSet);
            }

            return importedCount;
        }

        public static int SyncFromAudioDirectory(A07PALSOSDataSet dataSet)
        {
            Directory.CreateDirectory(AppPaths.AudioDirectory);
            int addedCount = 0;

            foreach (string filePath in Directory.GetFiles(AppPaths.AudioDirectory).Where(AppPaths.IsSupportedAudioFile).OrderBy(Path.GetFileName))
            {
                string fileName = Path.GetFileName(filePath);
                bool exists = dataSet.AUDIOFILES.Any(row =>
                    string.Equals(row.IsfilenameNull() ? string.Empty : row.filename, fileName, StringComparison.OrdinalIgnoreCase));
                if (exists)
                {
                    continue;
                }

                AddAudioRow(dataSet, GenerateNextId(dataSet), fileName, filePath);
                addedCount++;
            }

            if (addedCount > 0)
            {
                Save(dataSet);
            }

            return addedCount;
        }

        public static void UpdateDescription(A07PALSOSDataSet dataSet, string ms, string description)
        {
            A07PALSOSDataSet.AUDIOFILESRow row = dataSet.AUDIOFILES.FindByms(ms);
            if (row == null)
            {
                return;
            }

            row.description = description;
            Save(dataSet);
        }

        public static void DeleteAudioFile(A07PALSOSDataSet dataSet, string ms)
        {
            A07PALSOSDataSet.AUDIOFILESRow row = dataSet.AUDIOFILES.FindByms(ms);
            if (row == null)
            {
                return;
            }

            row.Delete();
            Save(dataSet);
        }

        private static void SeedFromAudioDirectory(A07PALSOSDataSet dataSet)
        {
            if (!Directory.Exists(AppPaths.AudioDirectory))
            {
                Directory.CreateDirectory(AppPaths.AudioDirectory);
                return;
            }

            int index = 1;
            foreach (string filePath in Directory.GetFiles(AppPaths.AudioDirectory).Where(AppPaths.IsSupportedAudioFile).OrderBy(Path.GetFileName))
            {
                string fileName = Path.GetFileName(filePath);
                string ms = "AU" + index.ToString("000");
                AddAudioRow(dataSet, ms, fileName, filePath);
                index++;
            }
        }

        private static void NormalizePaths(A07PALSOSDataSet dataSet)
        {
            foreach (A07PALSOSDataSet.AUDIOFILESRow row in dataSet.AUDIOFILES)
            {
                string resolvedPath = AppPaths.ResolveAudioFile(row.IsfilepathNull() ? string.Empty : row.filepath, row.IsfilenameNull() ? string.Empty : row.filename);
                if (!string.IsNullOrWhiteSpace(resolvedPath))
                {
                    row.filepath = resolvedPath;
                }
            }
        }

        private static void AddAudioRow(A07PALSOSDataSet dataSet, string ms, string fileName, string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            int sizeKb = fileInfo.Exists ? Convert.ToInt32(Math.Max(1, fileInfo.Length / 1024)) : 0;
            dataSet.AUDIOFILES.AddAUDIOFILESRow(ms, fileName, filePath, sizeKb, Path.GetExtension(fileName), 0, string.Empty);
        }

        private static string GenerateNextId(A07PALSOSDataSet dataSet)
        {
            int index = 1;
            while (dataSet.AUDIOFILES.FindByms("AU" + index.ToString("000")) != null)
            {
                index++;
            }

            return "AU" + index.ToString("000");
        }

        private static string CreateUniqueDestinationPath(string fileName)
        {
            string safeFileName = Path.GetFileName(fileName);
            string destinationPath = Path.Combine(AppPaths.AudioDirectory, safeFileName);
            if (!File.Exists(destinationPath))
            {
                return destinationPath;
            }

            string baseName = Path.GetFileNameWithoutExtension(safeFileName);
            string extension = Path.GetExtension(safeFileName);
            int copyIndex = 1;
            do
            {
                destinationPath = Path.Combine(AppPaths.AudioDirectory, baseName + "_" + copyIndex + extension);
                copyIndex++;
            }
            while (File.Exists(destinationPath));

            return destinationPath;
        }
    }
}

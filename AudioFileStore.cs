using System;
using System.IO;
using System.Linq;

namespace A07PALSOS
{
    internal static class AudioFileStore
    {
        private static readonly string StorePath = Path.Combine(AppPaths.DataDirectory, "AudioFiles.xml");

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

            dataSet.AUDIOFILES.AddAUDIOFILESRow(ms.Trim(), fileName, filePath, sizeKb, extension, 0, description);
            Save(dataSet);
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
    }
}

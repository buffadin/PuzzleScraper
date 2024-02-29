﻿using Microsoft.Extensions.Configuration;

namespace Arctic.Puzzlers.Stores
{
    public static class ConfigurationExtensions
    {
        private const string FileOutputFolderKey = "ResultOutputFolder";
        private const string OverrideDataKey = "OverrideData";
        private const string StoreTypeKey = "StoreType";

        public static string GetFileOutputFolder(this IConfiguration configuration)
        {
            return configuration[FileOutputFolderKey] ?? string.Empty;
        }

        public static string GetStoreType(this IConfiguration configuration)
        {
            return configuration[StoreTypeKey] ?? string.Empty;
        }

        public static bool OverrideData(this IConfiguration configuration)
        {
            var overrideData= configuration[OverrideDataKey];
            if (string.IsNullOrEmpty(overrideData))
            {
                return false;
            }
            return bool.Parse(overrideData);
        }
    }
}

﻿using System;
using System.Net.Http;
using FFImageLoading.Helpers;
using FFImageLoading.Cache;
using FFImageLoading.Work;

namespace FFImageLoading.Config
{
    public class Configuration
    {
        public Configuration(int maxCacheSize = 0, HttpClient httpClient = null, IWorkScheduler scheduler = null, IMiniLogger logger = null,
            IDiskCache diskCache = null, IDownloadCache downloadCache = null)
        {
            MaxCacheSize = maxCacheSize;
            HttpClient = httpClient;
            Scheduler = scheduler;
            Logger = logger;
            DiskCache = diskCache;
            DownloadCache = downloadCache;
        }

        /// <summary>
        /// Gets the maximum size of the cache in bytes.
        /// </summary>
        /// <value>The maximum size of the cache in bytes.</value>
        public int MaxCacheSize { get; private set; }

        /// <summary>
        /// Gets the HttpClient used for web requests.
        /// </summary>
        /// <value>The HttpClient used for web requests.</value>
        public HttpClient HttpClient { get; private set; }

        /// <summary>
        /// Gets the scheduler used to organize/schedule image loading tasks.
        /// </summary>
        /// <value>The scheduler used to organize/schedule image loading tasks.</value>
        public IWorkScheduler Scheduler { get; private set; }

        /// <summary>
        /// Gets the logger used to receive debug/error messages.
        /// </summary>
        /// <value>The logger.</value>
        public IMiniLogger Logger { get; private set; }

        /// <summary>
        /// Gets the disk cache.
        /// </summary>
        /// <value>The disk cache.</value>
        public IDiskCache DiskCache { get; private set; }

        /// <summary>
        /// Gets the download cache. Download cache is responsible for retrieving data from the web, or taking from the disk cache.
        /// </summary>
        /// <value>The download cache.</value>
        public IDownloadCache DownloadCache { get; private set; }
    }
}


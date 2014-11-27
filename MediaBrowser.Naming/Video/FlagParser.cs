﻿using MediaBrowser.Naming.Common;
using System;
using System.IO;

namespace MediaBrowser.Naming.Video
{
    public class FlagParser
    {
        private readonly NamingOptions _options;

        public FlagParser(NamingOptions options)
        {
            _options = options;
        }

        public string[] GetFlags(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("path");
            }

            // Note: the tags need be be surrounded be either a space ( ), hyphen -, dot . or underscore _.

            var file = Path.GetFileName(path);

            return file.Split(_options.VideoFlagDelimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

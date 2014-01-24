﻿using System;
using System.Text;

namespace FlatFileReaders
{
    /// <summary>
    /// Holds configuration settings for the FixedLengthParser class.
    /// </summary>
    public sealed class FixedLengthParserOptions
    {
        /// <summary>
        /// Initializes a new instance of a FixedLengthParserOptions.
        /// </summary>
        public FixedLengthParserOptions()
        {
            FillCharacter = ' ';
            RecordSeparator = Environment.NewLine;
        }

        /// <summary>
        /// Gets or sets the character used to buffer values in a column.
        /// </summary>
        public char FillCharacter { get; set; }

        /// <summary>
        /// Gets or sets the string that indicates the end of a record.
        /// </summary>
        public string RecordSeparator { get; set; }

        /// <summary>
        /// Gets or sets the encoding of the text source.
        /// </summary>
        /// <remarks>If the encoding is null, the default encoding will be used.</remarks>
        public Encoding Encoding { get; set; }
    }
}

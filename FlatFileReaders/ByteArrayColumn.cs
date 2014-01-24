﻿using System;
using System.Text;

namespace FlatFileReaders
{
    /// <summary>
    /// Represents a column of a byte[] values.
    /// </summary>
    public class ByteArrayColumn : ColumnDefinition
    {
        /// <summary>
        /// Initializes a new instance instance of a ByteArrayColumn.
        /// </summary>
        /// <param name="columnName">The name of the column.</param>
        public ByteArrayColumn(string columnName)
            : base(columnName)
        {
        }

        /// <summary>
        /// Gets the type of the values in the column.
        /// </summary>
        public override Type ColumnType
        {
            get { return typeof(byte[]); }
        }

        /// <summary>
        /// Gets or sets the encoding to use when parsing the value.
        /// </summary>
        public Encoding Encoding { get; set; }

        /// <summary>
        /// Parses the given value as a byte array.
        /// </summary>
        /// <param name="value">The value to parse.</param>
        /// <returns>The parsed byte array.</returns>
        public override object Parse(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return null;
            }
            value = value.Trim();
            Encoding encoding = Encoding ?? Encoding.Default;
            return encoding.GetBytes(value);
        }
    }
}

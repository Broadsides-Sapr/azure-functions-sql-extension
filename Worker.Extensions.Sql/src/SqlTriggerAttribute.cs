﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

namespace Microsoft.Azure.Functions.Worker.Extensions.Sql
{
    public sealed class SqlTriggerAttribute : TriggerBindingAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlTriggerAttribute"/> class, which triggers the function when any changes on the specified table are detected.
        /// </summary>
        /// <param name="tableName">Name of the table to watch for changes.</param>
        /// <param name="connectionStringSetting">The name of the app setting where the SQL connection string is stored</param>
        public SqlTriggerAttribute(string tableName, string connectionStringSetting)
        {
            this.TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
            this.ConnectionStringSetting = connectionStringSetting ?? throw new ArgumentNullException(nameof(connectionStringSetting));
        }

        /// <summary>
        /// Name of the app setting containing the SQL connection string.
        /// </summary>
        public string ConnectionStringSetting { get; }

        /// <summary>
        /// Name of the table to watch for changes.
        /// </summary>
        public string TableName { get; }
    }
}
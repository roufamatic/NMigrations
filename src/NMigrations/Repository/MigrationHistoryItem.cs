﻿/*
 *  Licensed to the Apache Software Foundation (ASF) under one or more
 *  contributor license agreements.  See the NOTICE file distributed with
 *  this work for additional information regarding copyright ownership.
 *  The ASF licenses this file to You under the Apache License, Version 2.0
 *  (the "License"); you may not use this file except in compliance with
 *  the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */

using System;

namespace NMigrations.Repository
{
    /// <summary>
    /// Represents a row from the migration history table.
    /// </summary>
    public class MigrationHistoryItem
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationHistoryItem"/> class.
        /// </summary>
        public MigrationHistoryItem()
        {

        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the date the migration was performed.
        /// </summary>
        /// <value>The date the migration was performed.</value>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of the migration that was applied.
        /// </summary>
        /// <value>The version of the migration.</value>
        public long Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the direction of the migration.
        /// </summary>
        /// <value>The direction of the migration.</value>
        public MigrationDirection Direction
        {
            get;
            set;
        }

        #endregion
    }
}
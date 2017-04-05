﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;

namespace Microsoft.VisualStudio.ProjectSystem
{
    /// <summary>
    ///     Represents a set of ordered active objects, such as a <see cref="ConfiguredProject"/> object or a <see cref="ProjectConfiguration"/> 
    ///     object, and the names of the configuration dimensions that participated in the calculation.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of the active configued objects.
    /// </typeparam>
    internal class ActiveConfiguredObjects<T>
    {
        /// <summary>
        ///     Initializes a new instance of <see cref="ActiveConfiguredObjects{T}"/> with the specified objects and configurations 
        ///     dimension names.
        /// </summary>
        /// <param name="objects">
        ///     An <see cref="ImmutableArray{T}"/> of the active configured objects.
        /// </param>
        /// <param name="dimensionNames">
        ///     An <see cref="IImmutableSet{T}"/> containing the names of the configuration dimensions that participated in 
        ///     the calculation of the active configured objects, or empty if no dimensions participated in the calculation.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="dimensionNames"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     <paramref name="objects"/> is empty.
        /// </exception>
        public ActiveConfiguredObjects(ImmutableArray<T> objects, IImmutableSet<string> dimensionNames)
        {
            Requires.NotNull(dimensionNames, nameof(dimensionNames));
            if (objects.Length == 0)
                throw new ArgumentException(null, nameof(objects));

            Objects = objects;
            DimensionNames = dimensionNames;
        }

        /// <summary>
        ///     Gets the active configured objects.
        /// </summary>
        /// <value>
        ///     An <see cref="ImmutableArray{T}"/> of the active configured objects.
        /// </value>
        public ImmutableArray<T> Objects
        {
            get;
        }

        /// <summary>
        ///     Gets the names of the configuration dimensions that participated in the calculation of the active configured objects.
        /// </summary>
        /// <value>
        ///     An <see cref="IImmutableSet{T}"/> containing the names of the configuration dimensions that participated in the
        ///     calculation of the active configured objects, or empty if no dimensions participated in the calculation.
        /// </value>
        public IImmutableSet<string> DimensionNames
        {
            get;
        }
    }
}

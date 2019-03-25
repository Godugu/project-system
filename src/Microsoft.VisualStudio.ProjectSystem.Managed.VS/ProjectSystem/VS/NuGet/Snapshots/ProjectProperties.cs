﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;

using NuGet.SolutionRestoreManager;

namespace Microsoft.VisualStudio.ProjectSystem.VS.NuGet
{
    internal class ProjectProperties : ImmutablePropertyCollection<IVsProjectProperty>, IVsProjectProperties
    {
        public ProjectProperties(IEnumerable<IVsProjectProperty> items)
            : base(items)
        {
        }

        protected override string GetKeyForItem(IVsProjectProperty value) => value.Name;
    }
}
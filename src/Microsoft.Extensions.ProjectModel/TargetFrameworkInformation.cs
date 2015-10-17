// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Extensions.ProjectModel.Graph;
using NuGet.Frameworks;

namespace Microsoft.Extensions.ProjectModel
{
    public class TargetFrameworkInformation : IFrameworkTargetable
    {
        public NuGetFramework FrameworkName { get; set; }

        public IReadOnlyList<LibraryRange> Dependencies { get; set; }

        public string WrappedProject { get; set; }

        public string AssemblyPath { get; set; }

        public string PdbPath { get; set; }

        public IEnumerable<NuGetFramework> SupportedFrameworks
        {
            get
            {
                return new[] { FrameworkName };
            }
        }
    }
}
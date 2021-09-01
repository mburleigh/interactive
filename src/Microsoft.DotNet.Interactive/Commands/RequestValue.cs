﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.DotNet.Interactive.Commands
{
    public class RequestValue : KernelCommand
    {
        public string Name { get; }
        
        public IReadOnlyCollection<string> MimeTypes { get; }

        public RequestValue(string name, string targetKernelName, IReadOnlyCollection<string> mimeTypes = null ) : base(targetKernelName)
        {
            Name = name;
            MimeTypes = mimeTypes;
        }
    }
}
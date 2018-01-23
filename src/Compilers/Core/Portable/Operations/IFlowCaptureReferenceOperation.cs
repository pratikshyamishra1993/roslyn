﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Operations
{
    /// <summary>
    /// Represents a point of use of an intermediate result captured earlier.
    /// PROTOTYPE(dataflow): Finalize the design how capturing/referencing intermediate results is represented.
    /// </summary>
    public interface IFlowCaptureReferenceOperation : IOperation
    {
        /// <summary>
        /// An id used to match references to the same intermediate result.
        /// </summary>
        int Id { get; }
    }
}

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;
using Microsoft.Azure.ServiceBus.Management;

namespace Microsoft.Azure.ServiceBus
{
    /// <summary>
    /// Matches all the messages arriving to be selected for the subscription.
    /// </summary>
    public sealed class TrueFilter : SqlFilter
    {
        internal static readonly TrueFilter Default = new TrueFilter();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFilter" /> class.
        /// </summary>
        public TrueFilter()
            : base("1=1")
        {
        }

        /// <summary>
        /// Converts the value of the current instance to its equivalent string representation.
        /// </summary>
        /// <returns>A string representation of the current instance.</returns>
        public override string ToString()
        {
            return "TrueFilter";
        }

        public override bool Equals(Filter other)
        {
            return other is TrueFilter;
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.KeyVault.Models
{
    /// <summary>
    /// The storage sas definition item containing storage sas definition metadata
    /// </summary>
    public partial class SasDefinitionItem
    {
        /// <summary>
        /// The storage account identifier
        /// </summary>
        public SasDefinitionIdentifier Identifier
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Id))
                    return new SasDefinitionIdentifier(Id);
                else
                    return null;
            }
        }
    }
}

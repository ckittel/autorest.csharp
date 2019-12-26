// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure;
using Azure.Core;

namespace AppConfiguration
{
    internal class CheckKeysHeaders
    {
        private readonly Response _response;
        public CheckKeysHeaders(Response response)
        {
            _response = response;
        }
        public string? SyncToken => _response.Headers.TryGetValue("Sync-Token", out string? value) ? value : null;
    }
}
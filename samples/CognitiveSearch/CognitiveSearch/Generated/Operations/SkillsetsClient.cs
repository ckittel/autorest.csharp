// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    public partial class SkillsetsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal SkillsetsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SkillsetsClient for mocking. </summary>
        protected SkillsetsClient()
        {
        }
        /// <summary> Initializes a new instance of SkillsetsClient. </summary>
        internal SkillsetsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string searchServiceName, string searchDnsSuffix = "search.windows.net", string apiVersion = "2019-05-06")
        {
            RestClient = new SkillsetsRestClient(clientDiagnostics, pipeline, searchServiceName, searchDnsSuffix, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateOrUpdateAsync(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(skillsetName, clientRequestId, ifMatch, ifNoneMatch, skillset, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> CreateOrUpdate(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(skillsetName, clientRequestId, ifMatch, ifNoneMatch, skillset, cancellationToken);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(skillsetName, clientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(skillsetName, clientRequestId, ifMatch, ifNoneMatch, cancellationToken);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> GetAsync(string skillsetName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(skillsetName, clientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Get(string skillsetName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(skillsetName, clientRequestId, cancellationToken);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListSkillsetsResult>> ListAsync(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, clientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListSkillsetsResult> List(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, clientRequestId, cancellationToken);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateAsync(Guid? clientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(clientRequestId, skillset, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Create(Guid? clientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(clientRequestId, skillset, cancellationToken);
        }
    }
}

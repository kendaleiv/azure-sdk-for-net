// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobCredential and their operations over its parent. </summary>
    public partial class JobCredentialCollection : ArmCollection, IEnumerable<JobCredential>, IAsyncEnumerable<JobCredential>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobCredentialsRestOperations _jobCredentialsRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobCredentialCollection"/> class for mocking. </summary>
        protected JobCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of JobCredentialCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JobCredentialCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _jobCredentialsRestClient = new JobCredentialsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => JobAgent.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_CreateOrUpdate
        /// <summary> Creates or updates a job credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="parameters"> The requested job credential state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual JobCredentialCreateOrUpdateOperation CreateOrUpdate(string credentialName, JobCredentialData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobCredentialsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, parameters, cancellationToken);
                var operation = new JobCredentialCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_CreateOrUpdate
        /// <summary> Creates or updates a job credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="parameters"> The requested job credential state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<JobCredentialCreateOrUpdateOperation> CreateOrUpdateAsync(string credentialName, JobCredentialData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobCredentialsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new JobCredentialCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Gets a jobs credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredential> Get(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _jobCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobCredential(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Gets a jobs credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<JobCredential>> GetAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobCredential(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredential> GetIfExists(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<JobCredential>(null, response.GetRawResponse())
                    : Response.FromValue(new JobCredential(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<JobCredential>> GetIfExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _jobCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<JobCredential>(null, response.GetRawResponse())
                    : Response.FromValue(new JobCredential(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(credentialName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_ListByAgent
        /// <summary> Gets a list of jobs credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobCredential" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobCredential> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobCredential> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialsRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobCredential> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialsRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_ListByAgent
        /// <summary> Gets a list of jobs credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobCredential" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobCredential> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobCredential>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialsRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobCredential>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialsRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<JobCredential> IEnumerable<JobCredential>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobCredential> IAsyncEnumerable<JobCredential>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, JobCredential, JobCredentialData> Construct() { }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    internal partial class PermissionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PermissionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public PermissionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2015-07-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListForResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Authorization/permissions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all permissions the caller has for a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get the permissions for. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<PermissionGetResult>> ListForResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListForResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all permissions the caller has for a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get the permissions for. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<PermissionGetResult> ListForResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListForResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForResourceRequest(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceProviderNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(parentResourcePath, false);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, false);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Authorization/permissions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all permissions the caller has for a resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing the resource. The name is case insensitive. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public async Task<Response<PermissionGetResult>> ListForResourceAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListForResourceRequest(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all permissions the caller has for a resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group containing the resource. The name is case insensitive. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public Response<PermissionGetResult> ListForResource(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListForResourceRequest(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForResourceGroupNextPageRequest(string nextLink, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all permissions the caller has for a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group to get the permissions for. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<PermissionGetResult>> ListForResourceGroupNextPageAsync(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListForResourceGroupNextPageRequest(nextLink, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all permissions the caller has for a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group to get the permissions for. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<PermissionGetResult> ListForResourceGroupNextPage(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListForResourceGroupNextPageRequest(nextLink, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForResourceNextPageRequest(string nextLink, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all permissions the caller has for a resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group containing the resource. The name is case insensitive. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public async Task<Response<PermissionGetResult>> ListForResourceNextPageAsync(string nextLink, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListForResourceNextPageRequest(nextLink, resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all permissions the caller has for a resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group containing the resource. The name is case insensitive. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public Response<PermissionGetResult> ListForResourceNextPage(string nextLink, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var message = CreateListForResourceNextPageRequest(nextLink, resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PermissionGetResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PermissionGetResult.DeserializePermissionGetResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

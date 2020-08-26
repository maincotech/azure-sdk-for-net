﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Storage;

namespace Microsoft.Azure.WebJobs.Host.Queues
{
    internal static class StorageQueueExtensions
    {
        public static async Task<SendReceipt> AddMessageAndCreateIfNotExistsAsync(this QueueClient queue,
            string message, CancellationToken cancellationToken)
        {
            if (queue == null)
            {
                throw new ArgumentNullException(nameof(queue));
            }

            bool isQueueNotFoundException = false;

            SendReceipt receipt = null;
            try
            {
                receipt = await queue.SendMessageAsync(message, cancellationToken).ConfigureAwait(false);
                return receipt;
            }
            catch (RequestFailedException exception)
            {
                if (!exception.IsNotFoundQueueNotFound())
                {
                    throw;
                }

                isQueueNotFoundException = true;
            }

            Debug.Assert(isQueueNotFoundException);
            await queue.CreateAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            receipt = await queue.SendMessageAsync(message, cancellationToken).ConfigureAwait(false);
            return receipt;
        }
    }
}

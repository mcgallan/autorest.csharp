// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtRenameRules
{
    internal class VirtualMachineScaleSetVmOperationSource : IOperationSource<VirtualMachineScaleSetVm>
    {
        private readonly ArmClient _client;

        internal VirtualMachineScaleSetVmOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualMachineScaleSetVm IOperationSource<VirtualMachineScaleSetVm>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineScaleSetVmData.DeserializeVirtualMachineScaleSetVmData(document.RootElement);
            return new VirtualMachineScaleSetVm(_client, data);
        }

        async ValueTask<VirtualMachineScaleSetVm> IOperationSource<VirtualMachineScaleSetVm>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineScaleSetVmData.DeserializeVirtualMachineScaleSetVmData(document.RootElement);
            return new VirtualMachineScaleSetVm(_client, data);
        }
    }
}
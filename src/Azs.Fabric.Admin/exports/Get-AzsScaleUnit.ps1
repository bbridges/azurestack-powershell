
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Returns the requested scale unit.
.Description
Returns the requested scale unit.
.Example
PS C:\> Get-AzsScaleUnit

A list of information about scale units.
.Example
PS C:\> Get-AzsScaleUnit -Name "S-Cluster"

The information about a specific scale unit.

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IFabricAdminIdentity>: Identity Parameter
  [Drive <String>]: Name of the storage drive.
  [EdgeGateway <String>]: Name of the edge gateway.
  [EdgeGatewayPool <String>]: Name of the edge gateway pool.
  [FabricLocation <String>]: Fabric location.
  [FileShare <String>]: Fabric file share name.
  [IPPool <String>]: IP pool name.
  [Id <String>]: Resource identity path
  [InfraRole <String>]: Infrastructure role name.
  [InfraRoleInstance <String>]: Name of an infrastructure role instance.
  [Location <String>]: Location of the resource.
  [LogicalNetwork <String>]: Name of the logical network.
  [LogicalSubnet <String>]: Name of the logical subnet.
  [MacAddressPool <String>]: Name of the MAC address pool.
  [Operation <String>]: Operation identifier.
  [ResourceGroupName <String>]: Name of the resource group.
  [ScaleUnit <String>]: Name of the scale units.
  [ScaleUnitNode <String>]: Name of the scale unit node.
  [SlbMuxInstance <String>]: Name of a SLB MUX instance.
  [StorageSubSystem <String>]: Name of the storage system.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  [Volume <String>]: Name of the storage volume.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/get-azsscaleunit
#>
function Get-AzsScaleUnit {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [System.String]
    # Name of the scale units.
    ${Name},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Azs.Fabric.Admin.custom\Get-AzsScaleUnit';
            Get = 'Azs.Fabric.Admin.custom\Get-AzsScaleUnit';
            GetViaIdentity = 'Azs.Fabric.Admin.custom\Get-AzsScaleUnit';
        }
        if (('List', 'Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('List', 'Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('List', 'Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
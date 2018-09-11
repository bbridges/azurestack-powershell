<#
Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License. See License.txt in the project root for license information.
#>

#
# Module manifest for module 'Azs.Fabric.Admin'
#
# Generated by: Microsoft
#
# Generated on: 2/21/2018
#

@{

    # Script module or binary module file associated with this manifest.
    RootModule        = 'Azs.Fabric.Admin.psm1'

    # Version number of this module.
    ModuleVersion     = '0.2.0'

    # Supported PSEditions
    # CompatiblePSEditions = @()

    # ID used to uniquely identify this module
    GUID              = '6ad9b0a0-a9c0-490c-83d3-02eeb307d1ad'

    # Author of this module
    Author            = 'Microsoft'

    # Company or vendor of this module
    CompanyName       = 'Microsoft'

    # Copyright statement for this module
    Copyright         = '(c) 2018 Microsoft. All rights reserved.'

    # Description of the functionality provided by this module
    Description       = 'Fabric Admin Client'

    # Minimum version of the Windows PowerShell engine required by this module
    PowerShellVersion = '5.0'

    # Name of the Windows PowerShell host required by this module
    # PowerShellHostName = ''

    # Minimum version of the Windows PowerShell host required by this module
    # PowerShellHostVersion = ''

    # Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
    # DotNetFrameworkVersion = ''

    # Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
    # CLRVersion = ''

    # Processor architecture (None, X86, Amd64) required by this module
    # ProcessorArchitecture = ''

    # Modules that must be imported into the global environment prior to importing this module
    RequiredModules   = @(@{ModuleName = 'AzureRM.Profile'; ModuleVersion = '5.5.1'; },
        @{ModuleName = 'AzureRM.Resources'; ModuleVersion = '6.0.2'; })

    # Assemblies that must be loaded prior to importing this module
    RequiredAssemblies = @('.\ref\fullclr\Microsoft.AzureStack.Management.Fabric.Admin.dll')

    # Script files (.ps1) that are run in the caller's environment prior to importing this module.
    # ScriptsToProcess = @()

    # Type files (.ps1xml) to be loaded when importing this module
    TypesToProcess    = @('Generated.PowerShell.Commands/FormatFiles/Azs.Fabric.Admin.Type.ps1xml')

    # Format files (.ps1xml) to be loaded when importing this module
    FormatsToProcess  = @('Generated.PowerShell.Commands/FormatFiles/Azs.Fabric.Admin.Format.ps1xml')

    # Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
    NestedModules     = @()

    # Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
    FunctionsToExport = 'Restart-AzsInfrastructureRoleInstance', 'Get-AzsStorageSystem',
    'Get-AzsScaleUnitNode', 'Disable-AzsScaleUnitNode',
    'Get-AzsLogicalNetwork', 'Get-AzsInfrastructureShare',
    'Get-AzsSlbMuxInstance', 'Get-AzsScaleUnit', 'New-AzsIpPool',
    'Start-AzsInfrastructureRoleInstance', 'Get-AzsMacAddressPool',
    'Get-AzsEdgeGatewayPool', 'Restart-AzsInfrastructureRole',
    'Get-AzsInfrastructureVolume', 'Enable-AzsScaleUnitNode',
    'Get-AzsInfrastructureRole', 'Get-AzsIpPool', 'Get-AzsLogicalSubnet',
    'Get-AzsEdgeGateway', 'Get-AzsInfrastructureLocation',
    'Get-AzsStoragePool', 'Suspend-AzsInfrastructureRoleInstance',
    'Start-AzsScaleUnitNode', 'Get-AzsInfrastructureRoleInstance',
    'Repair-AzsScaleUnitNode', 'Stop-AzsInfrastructureRoleInstance',
    'Stop-AzsScaleUnitNode', 'Add-AzsScaleUnitNode',
    'New-AzsScaleUnitNodeObject'

    # Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
    CmdletsToExport   = @()

    # Variables to export from this module
    # VariablesToExport = @()

    # Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
    AliasesToExport   = @()

    # DSC resources to export from this module
    # DscResourcesToExport = @()

    # List of all modules packaged with this module
    # ModuleList = @()

    # List of all files packaged with this module
    # FileList = @()

    # Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
    PrivateData       = @{

        PSData = @{

            # Tags applied to this module. These help with module discovery in online galleries.
            Tags         = @('AzureStack', 'Fabric', 'Admin', 'Azure Stack Fabric', 'Infrastructure', 'Scale Unit', 'FRP')

            # A URL to the license for this module.
            LicenseUri   = 'https://aka.ms/azps-license'

            # A URL to the main website for this project.
            ProjectUri   = 'https://github.com/Azure/azure-powershell'

            # A URL to an icon representing this module.
            # IconUri = ''

            # ReleaseNotes of this module
            ReleaseNotes = '## 2018.9.10
            * New Module dependencies
                * AzureRM.Profile
                * AzureRM.Resources
            * New cmdlet
                * Add-AzsScaleUnitNode
                * New-AzsScaleUnitNodeObject
            * Support handling names of nested resources
                * Add-AzsScaleUnitNode
                * Disable-AzsScaleUnitNode
                * Enable-AzsScaleUnitNode
                * Get-AzsEdgeGateway
                * Get-AzsEdgeGatewayPool
                * Get-AzsInfrastructureRole
                * Get-AzsInfrastructureRoleInstance
                * Get-AzsInfrastructureShare
                * Get-AzsInfrastructureVolume
                * Get-AzsIpPool
                * Get-AzsLogicalNetwork
                * Get-AzsLogicalSubnet
                * Get-AzsMacAddressPool
                * Get-AzsScaleUnit
                * Get-AzsScaleUnitNode
                * Get-AzsSlbMuxInstance
                * Get-AzsStoragePool
                * Get-AzsStorageSystem
                * Repair-AzsScaleUnitNode
                * Restart-AzsInfrastructureRole
                * Restart-AzsInfrastructureRoleInstance
                * Start-AzsInfrastructureRoleInstance
                * Start-AzsScaleUnitNode
                * Stop-AzsInfrastructureRoleInstance
                * Stop-AzsScaleUnitNode
            * Bug fixes
                * Handle ErrrorAction correctly now
            '

        } # End of PSData hashtable

    } # End of PrivateData hashtable

    # HelpInfo URI of this module
    # HelpInfoURI = ''

    # Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
    # DefaultCommandPrefix = ''

}



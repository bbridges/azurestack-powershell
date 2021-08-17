// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Create an IP pool. Once created an IP pool cannot be deleted.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fabric.Admin/fabricLocations/{location}/ipPools/{ipPool}"
    /// </remarks>
    [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"AzsIPPool_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Description(@"Create an IP pool.  Once created an IP pool cannot be deleted.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Generated]
    public partial class SetAzsIPPool_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>The address prefix.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The address prefix.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The address prefix.",
        SerializedName = @"addressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        public string AddressPrefix { get => PoolBody.AddressPrefix ?? null; set => PoolBody.AddressPrefix = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.FabricAdminClient Client => Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>The ending IP address.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ending IP address.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ending IP address.",
        SerializedName = @"endIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string EndIPAddress { get => PoolBody.EndIPAddress ?? null; set => PoolBody.EndIPAddress = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Location of the resource.")]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzLocation)[0].Location")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Path)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>The region where the resource is located.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The region where the resource is located.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The region where the resource is located.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location1 { get => PoolBody.Location ?? null; set => PoolBody.Location = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>IP pool name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "IP pool name.")]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"IP pool name.",
        SerializedName = @"ipPool",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>The number of currently allocated IP addresses.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of currently allocated IP addresses.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of currently allocated IP addresses.",
        SerializedName = @"numberOfAllocatedIpAddresses",
        PossibleTypes = new [] { typeof(long) })]
        public long NumberOfAllocatedIPAddress { get => PoolBody.NumberOfAllocatedIPAddresses ?? default(long); set => PoolBody.NumberOfAllocatedIPAddresses = value; }

        /// <summary>The total number of IP addresses.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The total number of IP addresses.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of IP addresses.",
        SerializedName = @"numberOfIpAddresses",
        PossibleTypes = new [] { typeof(long) })]
        public long NumberOfIPAddress { get => PoolBody.NumberOfIPAddresses ?? default(long); set => PoolBody.NumberOfIPAddresses = value; }

        /// <summary>The current number of IP addresses in transition.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The current number of IP addresses in transition.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current number of IP addresses in transition.",
        SerializedName = @"numberOfIpAddressesInTransition",
        PossibleTypes = new [] { typeof(long) })]
        public long NumberOfIPAddressesInTransition { get => PoolBody.NumberOfIPAddressesInTransition ?? default(long); set => PoolBody.NumberOfIPAddressesInTransition = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="PoolBody" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool _poolBody= new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IPPool();

        /// <summary>
        /// This resource defines the range of IP addresses from which addresses are allocated for nodes within a subnet.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool PoolBody { get => this._poolBody; set => this._poolBody = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>Name of the resource group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the resource group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"-join(""System."",(Get-AzLocation)[0].Location)")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>The starting IP address.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The starting IP address.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The starting IP address.",
        SerializedName = @"startIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        public string StartIPAddress { get => PoolBody.StartIPAddress ?? null; set => PoolBody.StartIPAddress = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.")]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>List of key-value pairs.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of key-value pairs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category(global::Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => PoolBody.Tag ?? null /* object */; set => PoolBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of SetAzsIPPool_UpdateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Cmdlets.SetAzsIPPool_UpdateExpanded Clone()
        {
            var clone = new SetAzsIPPool_UpdateExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone.PoolBody = this.PoolBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Location = this.Location;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.DelayBeforePolling:
                    {
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            var data = messageData();
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'IPPoolsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.IPPoolsCreateOrUpdate(SubscriptionId, ResourceGroupName, Location, Name, PoolBody, onOk, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Location=Location,Name=Name,body=PoolBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SetAzsIPPool_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public SetAzsIPPool_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool
                WriteObject((await response));
            }
        }
    }
}
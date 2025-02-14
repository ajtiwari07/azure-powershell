// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the response header action for the delivery rule.</summary>
    public partial class DeliveryRuleResponseHeaderAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleResponseHeaderAction,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleResponseHeaderActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1 __deliveryRuleAction1 = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.DeliveryRuleAction1();

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleResponseHeaderActionInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.HeaderActionParameters()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterTypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleResponseHeaderActionInternal.ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).TypeName = value; }

        /// <summary>The name of the action for the delivery rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name = value ; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParameters _parameter;

        /// <summary>Defines the parameters for the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.HeaderActionParameters()); set => this._parameter = value; }

        /// <summary>Action to perform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction ParameterHeaderAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).HeaderAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).HeaderAction = value ; }

        /// <summary>Name of the header to modify</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterHeaderName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).HeaderName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).HeaderName = value ; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).TypeName; }

        /// <summary>Value for the specified action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParametersInternal)Parameter).Value = value ?? null; }

        /// <summary>Creates an new <see cref="DeliveryRuleResponseHeaderAction" /> instance.</summary>
        public DeliveryRuleResponseHeaderAction()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
            await eventListener.AssertObjectIsValid(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
        }
    }
    /// Defines the response header action for the delivery rule.
    public partial interface IDeliveryRuleResponseHeaderAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1
    {
        /// <summary>Action to perform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Action to perform",
        SerializedName = @"headerAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction ParameterHeaderAction { get; set; }
        /// <summary>Name of the header to modify</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the header to modify",
        SerializedName = @"headerName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterHeaderName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterTypeName { get;  }
        /// <summary>Value for the specified action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value for the specified action",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterValue { get; set; }

    }
    /// Defines the response header action for the delivery rule.
    internal partial interface IDeliveryRuleResponseHeaderActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IDeliveryRuleAction1Internal
    {
        /// <summary>Defines the parameters for the action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IHeaderActionParameters Parameter { get; set; }
        /// <summary>Action to perform</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction ParameterHeaderAction { get; set; }
        /// <summary>Name of the header to modify</summary>
        string ParameterHeaderName { get; set; }

        string ParameterTypeName { get; set; }
        /// <summary>Value for the specified action</summary>
        string ParameterValue { get; set; }

    }
}
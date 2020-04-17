namespace Microsoft.Graph.PowerShell.Cmdlets.Custom
{
    using System.Collections.Generic;
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;

    public partial class ListCmdlet : global::System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="All" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _all;

        /// <summary>List All pages</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List all pages")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List all pages",
        SerializedName = @"$all",
        PossibleTypes = new[] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter All { get => this._all; set => this._all = value; }

        public bool ShouldIteratePages(Dictionary<string, object> boundParameters)
        {
            if (boundParameters.ContainsKey("All"))
                return true;
            return false;

        }
    }
}

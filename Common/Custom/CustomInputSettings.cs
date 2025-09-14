namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;

/// <summary>
/// Display settings custom to this specific project.
/// </summary>
[DataContract]
public class CustomInputSettings : CopyableSettings<CustomInputSettings> {
    /// <inheritdoc />
    public override void CopyTo(CustomInputSettings other) {
    }
}
namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;

/// <summary>
/// Display settings custom to this specific project.
/// </summary>
[DataContract]
public class CustomDisplaySettings : CopyableSettings<CustomDisplaySettings> {
    /// <inheritdoc />
    public override void CopyTo(CustomDisplaySettings other) {
        base.CopyTo(other);
        // TODO: copy more
    }
}
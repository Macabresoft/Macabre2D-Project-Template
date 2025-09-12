namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;

/// <summary>
/// Display settings custom to this specific project.
/// </summary>
[DataContract]
public class CustomDisplaySettings {
    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <remarks>This method is required by Macabre2D.</remarks>
    /// <returns>The cloned settings.</returns>
    public CustomDisplaySettings Clone() {
        var clone = new CustomDisplaySettings();
        this.CopyTo(clone);
        return clone;
    }

    /// <summary>
    /// Copies settings to another instance.
    /// </summary>
    /// <remarks>This method is required by Macabre2D.</remarks>
    /// <param name="other">The other instance.</param>
    public void CopyTo(CustomDisplaySettings other) {
    }
}
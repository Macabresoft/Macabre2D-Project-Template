namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;
using Macabresoft.Macabre2D.Common;

/// <summary>
/// Represents a settings file that can be copied.
/// </summary>
/// <typeparam name="T">The type of settings that can be copied and cloned.</typeparam>
[DataContract]
public abstract class CopyableSettings<T> : VersionedData where T : CopyableSettings<T>, new() {
    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <remarks>This method is required by Macabre2D.</remarks>
    /// <returns>The cloned settings.</returns>
    public virtual T Clone() {
        var clone = new T();
        this.CopyTo(clone);
        return clone;
    }

    /// <summary>
    /// Copies settings to another instance.
    /// </summary>
    /// <remarks>This method is required by Macabre2D.</remarks>
    /// <param name="other">The other instance.</param>
    public virtual void CopyTo(T other) {
        other.Version = this.Version;
    }
}
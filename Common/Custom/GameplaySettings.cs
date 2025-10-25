namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;

/// <summary>
/// Gameplay settings specific to this project.
/// </summary>
[DataContract]
public class GameplaySettings : CopyableSettings<GameplaySettings> {
    /// <summary>
    /// Gets or sets the user who owns these settings.
    /// </summary>
    /// <remarks>
    /// This is an example setting and may be removed without consequence.
    /// </remarks>
    [DataMember]
    public string UserName { get; set; } = string.Empty;

    /// <inheritdoc />
    public override void CopyTo(GameplaySettings other) {
        base.CopyTo(other);
        other.UserName = this.UserName;
    }
}
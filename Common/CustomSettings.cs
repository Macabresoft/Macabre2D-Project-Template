namespace Macabresoft.Macabre2D.Project.Common;

using System.Runtime.Serialization;

/// <summary>
/// Settings custom to this specific project.
/// </summary>
[DataContract]
public class CustomSettings {
    /// <summary>
    /// Gets or sets the author of this project.
    /// </summary>
    /// <remarks>
    /// This is an example setting and may be removed without consequence.
    /// </remarks>
    [DataMember]
    public string Author { get; set; }
}
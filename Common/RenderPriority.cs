namespace Macabresoft.Macabre2D.Project.Common;

/// <summary>
/// The layers to be used when determining the render order of renderable entities.
/// </summary>
public enum RenderPriority : byte {
    Default = 0,
    Final = byte.MaxValue
}
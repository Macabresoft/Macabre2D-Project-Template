namespace Macabresoft.Macabre2D.Project.Common;

using Macabresoft.Core;
using Macabresoft.Macabre2D.Common;

/// <summary>
/// A class accessible via the containing game that can include any information about the currently running game that might be relevant in the current scene or across scenes.
/// </summary>
public class GameState {
    private IDataManager _dataManager = EmptyDataManager.Instance;

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    /// <param name="dataManager">The data manager.</param>
    /// <param name="customSettings">The custom settings.</param>
    public void Initialize(IDataManager dataManager, CustomSettings customSettings) {
        this._dataManager = dataManager;
    }
}
namespace Macabresoft.Macabre2D.Project.Common;

using Macabresoft.Macabre2D.Common;

/// <summary>
/// Manages save files.
/// </summary>
public class SaveManager {
    private IDataManager _dataManager = EmptyDataManager.Instance;

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    /// <param name="dataManager">The data manager.</param>
    public void Initialize(IDataManager dataManager) {
        this._dataManager = dataManager;
    }
}
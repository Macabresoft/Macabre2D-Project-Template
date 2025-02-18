namespace Macabresoft.Macabre2D.Project.Common;

using Macabresoft.Core;
using Macabresoft.Macabre2D.Common;

/// <summary>
/// Events that can be raised to the game.
/// </summary>
public enum GameAction {
    Shutdown,
    SaveSettings,
    SaveAndApplySettings
}

/// <summary>
/// A class accessible via the containing game that can include any information about the currently running game that might be relevant in the current scene or across scenes.
/// </summary>
public class GameState {
    private IDataManager _dataManager = EmptyDataManager.Instance;

    /// <summary>
    /// An event that is called when it is requested that the game should perform a specific action.
    /// </summary>
    public event EventHandler<GameAction>? ActionRequested;

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    /// <param name="dataManager">The data manager.</param>
    /// <param name="customSettings">The custom settings.</param>
    public void Initialize(IDataManager dataManager, CustomSettings customSettings) {
        this._dataManager = dataManager;
    }

    /// <summary>
    /// Raises an event which requests an action be taken by the game.
    /// </summary>
    /// <param name="action">The action.</param>
    public void RaiseActionRequested(GameAction action) {
        this.ActionRequested.SafeInvoke(this, action);
    }
}
using SyskenTLib.CommonAppConfig.Internal;
using UnityEngine;

namespace SyskenTLib.CommonAppConfig
{
    public class GameConfig :ConfigBase
    {
        [Space(30)]
        [Header("個別パラーメータ")]

        [SerializeField]
        private GameMode  _gameMode = GameMode.Normal;
        /// <summary>
        /// ゲームモード
        /// </summary>
        public GameMode GetGameMode => _gameMode;
    }
}
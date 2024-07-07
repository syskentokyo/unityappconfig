using UnityEngine;
using UnityEngine.Serialization;

namespace SyskenTLib.CommonAppConfig
{
    public class AppRootConfig : ScriptableObject
    {
        [Header("Basic")]
        [SerializeField]private BasicAppConfig _basicAppConfig;
        public BasicAppConfig GetBasicAppConfig => _basicAppConfig;

        [Header("API")] [SerializeField] private APIConfig _apiConfig;
        public APIConfig GetAPIConfig => _apiConfig;

        
        [Header("WebSite")] [SerializeField] private WebSiteConfig _webSiteConfig;
        public WebSiteConfig GetWebSiteConfig => _webSiteConfig;
        
        
        [Header("Game")] [SerializeField] private GameConfig _gameConfig;
        public GameConfig GetGameConfig => _gameConfig;
    }
}
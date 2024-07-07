using SyskenTLib.CommonAppConfig.Internal;
using UnityEngine;

namespace SyskenTLib.CommonAppConfig
{
    public class ConfigBase : ScriptableObject
    {
        [Header("設定ファイルについて")]
        [SerializeField]private ConfigType _configType = ConfigType.Dev1;

        public ConfigType GetConfigType => _configType;

        [SerializeField] private string _configVersion = "1.0.0";
        public string GetConfigVersion => _configVersion;
        
        [SerializeField] private string _configDisplayName = "Release";
        public string GetConfigDisplayName => _configDisplayName;
        
        
        
    }
}
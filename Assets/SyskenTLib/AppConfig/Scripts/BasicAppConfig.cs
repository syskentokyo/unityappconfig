using UnityEngine;
using SyskenTLib.CommonAppConfig.Internal;


namespace SyskenTLib.CommonAppConfig
{
    

    public class BasicAppConfig : ConfigBase
    {
        [Space(30)] [Header("個別パラーメータ")] 
        
        [SerializeField,TextArea(1,3)]
        private string _displayAppVersion= "1.0.0";
        /// <summary>
        /// 表示用アプリバージョン
        /// </summary>
        public string GetDisplayAppVersion => _displayAppVersion;

    }
}
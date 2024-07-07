using SyskenTLib.CommonAppConfig.Internal;
using UnityEngine;

namespace SyskenTLib.CommonAppConfig
{

    public class APIConfig : ConfigBase
    {
        [Space(30)] [Header("個別パラーメータ")] 
        
        [SerializeField,TextArea(1,3)]
        private string _checkServiceStatusAPIURL = "";
        /// <summary>
        /// サービスの状態を取得するAPIのURL
        /// </summary>
        public string GetCheckServiceStatusAPIURL => _checkServiceStatusAPIURL;

    }
}
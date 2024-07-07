using SyskenTLib.CommonAppConfig.Internal;
using UnityEngine;

namespace SyskenTLib.CommonAppConfig
{

    public class WebSiteConfig : ConfigBase
    {
        [Space(30)] [Header("個別パラーメータ")] 
        
        [SerializeField,TextArea(1,3)]
        private string _serviceOfficialWebSite1 = "";
        /// <summary>
        /// サービス公式サイト1のURL
        /// </summary>
        public string GetServiceOfficialWebSite1 => _serviceOfficialWebSite1;
    }
}
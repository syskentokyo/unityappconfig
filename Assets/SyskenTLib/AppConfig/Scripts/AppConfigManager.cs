using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SyskenTLib.CommonAppConfig
{
    [DefaultExecutionOrder(-999)]//一番最初に生成する
    public class AppConfigManager : MonoBehaviour
    {

        [SerializeField] private AppRootConfig _appRootConfig;

        public static AppConfigManager instance;
        

        private void Awake()
        {
            if( instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        public BasicAppConfig GetBasicConfig()
        {
            
            return _appRootConfig.GetBasicAppConfig;
        }
        
        public APIConfig GetAPIConfig()
        {
            
            return _appRootConfig.GetAPIConfig;
        }
        
        public WebSiteConfig GetWebSiteConfig()
        {
            
            return _appRootConfig.GetWebSiteConfig;
        }
        
    }
}

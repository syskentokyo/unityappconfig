namespace SyskenTLib.CommonAppConfig.Internal
{
    
    public enum ConfigType:int
    {
        UnityEditor=-1,
        Release=0,
        Adhoc1=1,
        Adhoc2=2,
        Dev1=3,
        Dev2=4,
        Dev3=5,
        Private1=6,
        Private2=7,
    }

    public enum GameMode : int
    {
        Normal=1
        
        //体験版
        ,Trial1=11
        ,Trial2=12
        
        //デモモード
        ,Demo1=31
        ,Demo2=32
        
        //デバッグ用
        ,DebugAllMax =200
    }
    
    
    public class CommonDefine
    {
        
    }
}
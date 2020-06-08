# Uni Android External Tools

![2020-05-01_125410](https://user-images.githubusercontent.com/61863367/80780759-03582c00-8bab-11ea-8048-bd71d4751d3c.png)

External Tools の Android の項目の取得または設定ができるパッケージ

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public static class Example
{
    [MenuItem( "Tools/Log" )]
    private static void Log()
    {
        // JDK Installed with Unity (recommended) 
        Debug.Log( "JdkInstalledWithUnity: " + AndroidExternalTools.JdkInstalledWithUnity );

        // JDK のパス
        Debug.Log( "JdkPath: " + AndroidExternalTools.JdkPath );

        // Android SDK Tools Installed with Unity (recommended)
        Debug.Log( "AndroidSdkToolsInstalledWithUnity: " + AndroidExternalTools.AndroidSdkToolsInstalledWithUnity );
        
        // Android SDK Tools のパス
        Debug.Log( "SdkPath: " + AndroidExternalTools.SdkPath );

        //  Android NDK Installed with Unity (recommended)
        Debug.Log( "AndroidNdkInstalledWithUnity: " + AndroidExternalTools.AndroidNdkInstalledWithUnity );

        // Android NDK のパス
        Debug.Log( "NdkPath: " + AndroidExternalTools.NdkPath );

        // Android NDK のパス（Unity 2018.3 以降）
        Debug.Log( "NdkR16bPath: " + AndroidExternalTools.NdkR16bPath );

        // Android NDK のパス（Unity ????.? 以降）
        Debug.Log( "NdkR19Path: " + AndroidExternalTools.NdkR19Path );

        // Gradle Installed with Unity (recommended) 
        Debug.Log( "GradleInstalledWithUnity: " + AndroidExternalTools.GradleInstalledWithUnity );

        // Gradle のパス
        Debug.Log( "GradlePath: " + AndroidExternalTools.GradlePath );

        // Stop Gradle daemons on exit
        Debug.Log( "StopGradleDaemonsOnExit: " + AndroidExternalTools.StopGradleDaemonsOnExit );

        // Maximum JVM heap size, Mbytes
        Debug.Log( "MaximumJvmHeadSizeMbytes: " + AndroidExternalTools.MaximumJvmHeadSizeMbytes );

        //  Keystores Dedicated Location
        Debug.Log( "KeystoresDedicatedLocation: " + AndroidExternalTools.KeystoresDedicatedLocation );
    }
}
```
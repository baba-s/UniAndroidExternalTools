using UnityEditor;

namespace UniAndroidExternalTools
{
	/// <summary>
	/// External Tools の Android の項目の取得または設定ができる関数
	/// </summary>
	public static class AndroidExternalTools
	{
		//================================================================================
		// 定数
		//================================================================================
		private const string KEY_JDK_PATH                                  = "JdkPath";
		private const string KEY_JDK_USE_EMBEDDED                          = "JdkUseEmbedded";
		private const string KEY_SDK_PATH                                  = "AndroidSdkRoot";
		private const string KEY_SDK_USE_EMBEDDED                          = "SdkUseEmbedded";
		private const string KEY_NDK_PATH                                  = "AndroidNdkRoot";
		private const string KEY_NDK_R16B_PATH                             = "AndroidNdkRootR16b";
		private const string KEY_NDK_R19_PATH                              = "AndroidNdkRootR19";
		private const string KEY_NDK_USE_EMBEDDED                          = "NdkUseEmbedded";
		private const string KEY_GRADLE_PATH                               = "GradlePath";
		private const string KEY_GRADLE_USE_EMBEDDED                       = "GradleUseEmbedded";
		private const string KEY_ANDROID_GRADLE_STOP_DAEMONS_ON_EXIT       = "AndroidGradleStopDaemonsOnExit";
		private const string KEY_ANDROID_JVM_MAX_HEAP_SIZE                 = "AndroidJVMMaxHeapSize";
		private const string KEY_ANDROID_KEYSTORES_DEDICATED_LOCATION_ROOT = "AndroidKeystoresDedicatedLocationRoot";
		
		//================================================================================
		// プロパティ(static)
		//================================================================================
		/// <summary>
		/// JDK Installed with Unity (recommended) の項目の取得または設定をします
		/// </summary>
		public static bool JdkInstalledWithUnity
		{
			get => EditorPrefs.GetBool( KEY_JDK_USE_EMBEDDED );
			set => EditorPrefs.SetBool( KEY_JDK_USE_EMBEDDED, value );
		}
		
		/// <summary>
		/// JDK のパスの項目の取得または設定をします
		/// </summary>
		public static string JdkPath
		{
			get => EditorPrefs.GetString( KEY_JDK_PATH );
			set => EditorPrefs.SetString( KEY_JDK_PATH, value );
		}
		
		/// <summary>
		/// Android SDK Tools Installed with Unity (recommended) の項目の取得または設定をします
		/// </summary>
		public static bool AndroidSdkToolsInstalledWithUnity
		{
			get => EditorPrefs.GetBool( KEY_SDK_USE_EMBEDDED );
			set => EditorPrefs.SetBool( KEY_SDK_USE_EMBEDDED, value );
		}
		
		/// <summary>
		/// Android SDK Tools のパスの項目の取得または設定をします
		/// </summary>
		public static string SdkPath
		{
			get => EditorPrefs.GetString( KEY_SDK_PATH );
			set => EditorPrefs.SetString( KEY_SDK_PATH, value );
		}
		
		/// <summary>
		/// Android NDK Installed with Unity (recommended) の項目の取得または設定をします
		/// </summary>
		public static bool AndroidNdkInstalledWithUnity
		{
			get => EditorPrefs.GetBool( KEY_NDK_USE_EMBEDDED );
			set => EditorPrefs.SetBool( KEY_NDK_USE_EMBEDDED, value );
		}
		
		/// <summary>
		/// Android NDK のパスの項目の取得または設定をします
		/// </summary>
		public static string NdkPath
		{
			get => EditorPrefs.GetString( KEY_NDK_PATH );
			set => EditorPrefs.SetString( KEY_NDK_PATH, value );
		}
		
		/// <summary>
		/// Android NDK のパスの項目の取得または設定をします（Unity 2018.3 以降）
		/// </summary>
		public static string NdkR16bPath
		{
			get => EditorPrefs.GetString( KEY_NDK_R16B_PATH );
			set => EditorPrefs.SetString( KEY_NDK_R16B_PATH, value );
		}
		
		/// <summary>
		/// Android NDK のパスの項目の取得または設定をします（Unity ????.? 以降）
		/// </summary>
		public static string NdkR19Path
		{
			get => EditorPrefs.GetString( KEY_NDK_R19_PATH );
			set => EditorPrefs.SetString( KEY_NDK_R19_PATH, value );
		}
		
		/// <summary>
		/// Gradle Installed with Unity (recommended) の項目の取得または設定をします
		/// </summary>
		public static bool GradleInstalledWithUnity
		{
			get => EditorPrefs.GetBool( KEY_GRADLE_USE_EMBEDDED );
			set => EditorPrefs.SetBool( KEY_GRADLE_USE_EMBEDDED, value );
		}
		
		/// <summary>
		/// Gradle のパスの項目の取得または設定をします
		/// </summary>
		public static string GradlePath
		{
			get => EditorPrefs.GetString( KEY_GRADLE_PATH );
			set => EditorPrefs.SetString( KEY_GRADLE_PATH, value );
		}
		
		/// <summary>
		/// Stop Gradle daemons on exit の項目の取得または設定をします
		/// </summary>
		public static bool StopGradleDaemonsOnExit
		{
			get => EditorPrefs.GetBool( KEY_ANDROID_GRADLE_STOP_DAEMONS_ON_EXIT );
			set => EditorPrefs.SetBool( KEY_ANDROID_GRADLE_STOP_DAEMONS_ON_EXIT, value );
		}
		
		/// <summary>
		/// Maximum JVM heap size, Mbytes の項目の取得または設定をします
		/// </summary>
		public static int MaximumJvmHeadSizeMbytes 
		{ 
			get => EditorPrefs.GetInt( KEY_ANDROID_JVM_MAX_HEAP_SIZE ); 
			set => EditorPrefs.SetInt( KEY_ANDROID_JVM_MAX_HEAP_SIZE, value );
		}
		
		/// <summary>
		/// Keystores Dedicated Location の項目の取得または設定をします
		/// </summary>
		public static string KeystoresDedicatedLocation
		{
			get => EditorPrefs.GetString( KEY_ANDROID_KEYSTORES_DEDICATED_LOCATION_ROOT );
			set => EditorPrefs.SetString( KEY_ANDROID_KEYSTORES_DEDICATED_LOCATION_ROOT, value );
		}
	}
}
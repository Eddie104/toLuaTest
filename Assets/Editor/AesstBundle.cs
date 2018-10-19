using System.Collections;
using System.IO;
using UnityEditor;
using UnityEngine;
public class AesstBundle : MonoBehaviour {

    [MenuItem ("Tools/Package AssetBundle")]
    private static void PackageBuddle () {
        Debug.Log ("<color=#FF0000>Packaging AssetBundle...</color>");
        string abPath = Application.dataPath + "/AssetBundles";
        Directory.Delete (abPath, true);
        Directory.CreateDirectory (abPath);
        // if (!Directory.Exists (abPath)) {

        // }
        BuildPipeline.BuildAssetBundles (abPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);
        // AssetDatabase.Refresh ();
        Debug.Log ("<color=#FF0000>Packaging AssetBundle Done</color>");
    }

    // [MenuItem ("Custom Bundle/Create Bundel Main")]
    // public static void creatBundleMain () {
    //     //获取选择的对象的路径
    //     Object[] os = Selection.GetFiltered (typeof (Object), SelectionMode.DeepAssets);
    //     bool isExist = Directory.Exists (Application.dataPath + "/StreamingAssets");
    //     if (!isExist) {
    //         Directory.CreateDirectory (Application.dataPath + "/StreamingAssets");
    //     }
    //     foreach (Object o in os) {
    //         string sourcePath = AssetDatabase.GetAssetPath (o);

    //         string targetPath = Application.dataPath + "/StreamingAssets/" + o.name + ".assetbundle";
    //         if (BuildPipeline.BuildAssetBundle (o, null, targetPath, BuildAssetBundleOptions.CollectDependencies)) {
    //             print ("create bundle cuccess!");
    //         } else {
    //             print ("failure happen");
    //         }
    //         AssetDatabase.Refresh ();
    //     }
    // }

    // [MenuItem ("Custom Bundle/Create Bundle All")]
    // public static void CreateBundleAll () {
    //     bool isExist = Directory.Exists (Application.dataPath + "/StreamingAssets");
    //     if (!isExist) {
    //         Directory.CreateDirectory (Application.dataPath + "/StreamingAssets");
    //     }
    //     Object[] os = Selection.GetFiltered (typeof (Object), SelectionMode.DeepAssets);
    //     if (os == null || os.Length == 0) {
    //         return;
    //     }
    //     string targetPath = Application.dataPath + "/StreamingAssets/" + "All.assetbundle";
    //     if (BuildPipeline.BuildAssetBundle (null, os, targetPath, BuildAssetBundleOptions.CollectDependencies)) {
    //         print ("create bundle all cuccess");
    //     } else {
    //         print ("failure happen");
    //     }
    //     AssetDatabase.Refresh ();
    // }

}

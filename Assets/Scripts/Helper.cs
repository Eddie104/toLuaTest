using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public static class Helper {
    public static bool EditorMode () {
#if UNITY_EDITOR
        return true;
#else
        return false;
#endif
    }

    public static string Platform () {
#if UNITY_STANDALONE
        return "win";
#elif UNITY_ANDROID
        return "android";
#elif UNITY_IPHONE
        return "iOS";
#else
        return "";
#endif
    }

    public static string DecodeBase64 (string code) {
        byte[] bytes = Convert.FromBase64String (code);
        //从byBuf数组的第三个字节开始初始化实例
        using (MemoryStream ms = new MemoryStream (bytes, 2, bytes.Length - 2)) {
            using (DeflateStream decompressionStream = new DeflateStream (ms, CompressionMode.Decompress, true)) {
                StreamReader streamR = new StreamReader (decompressionStream, Encoding.Default);
                string strDeompressed = streamR.ReadToEnd ();
                return strDeompressed;
            }
        }
    }
}
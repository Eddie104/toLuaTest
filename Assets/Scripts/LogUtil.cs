using UnityEngine;

public static class LogUtil {
    public static void Info (string content) {
        UnityEngine.Debug.Log ("[info]-><color=#FFFFFF>" + content + "</color>");
    }

    public static void Warn (string content) {
        UnityEngine.Debug.Log ("[warn]-><color=#FFFF00>" + content + "</color>");
    }

    public static void Debug (string content) {
        UnityEngine.Debug.Log ("[debug]-><color=#00EEEE>" + content + "</color>");
    }

    public static void Error (string content) {
        UnityEngine.Debug.Log ("[error]-><color=#FF0000>" + content + "</color>");
    }
}
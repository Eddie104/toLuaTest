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
}
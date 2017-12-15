using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ScreenShotsEditor {

    [MenuItem("Lelouch/ScreenShots")]
    public static void ScreenShots()
    {
        GameObject go = Selection.activeGameObject;

        if (!go)
        {
            Debug.LogErrorFormat("Please sure you selected one gameobject!");
        }
        Text text = go.transform.Find("Title").GetComponent<Text>();
        if (text)
        {
            string n = text.font.name;
            Debug.LogFormat("Current text font is : {0}",n);
            text.text = text.font.name;

            ScreenCapture.CaptureScreenshot(Application.dataPath + "/" + n +".png", 1);
            AssetDatabase.Refresh();
            
        }
    }
}

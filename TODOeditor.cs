using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TODOeditor : EditorWindow
{
    string todoString;
    [MenuItem("Window/TODO")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(TODOeditor));

    }



    public void OnGUI()
    {


        todoString = EditorGUILayout.TextArea(todoString,GUILayout.MinHeight(position.height));
        SaveChanges();
    }


    public void SaveChanges()
    {
        base.SaveChanges();
    }
}

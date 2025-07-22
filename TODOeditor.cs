using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class TODOeditor : EditorWindow
{
    static string todoString;
    [MenuItem("Window/Todo")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(TODOeditor));
    }

    private void OnEnable()
    {
        todoString = EditorPrefs.GetString("editorTodoString");

    }


    public void OnGUI()
    {
        todoString = EditorGUILayout.TextArea(todoString, GUILayout.MinHeight(position.height));

        Save();
    }


    public void Save() => EditorPrefs.SetString("editorTodoString", todoString);
}

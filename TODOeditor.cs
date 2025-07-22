using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TODOeditor : EditorWindow
{
    static string todoString;
    [MenuItem("Window/Todo")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(TODOeditor));
    }

    public void Awake()
    {
        todoString = EditorPrefs.GetString("editorTodoString");
    }

    public void OnGUI()
    {
        todoString = EditorGUILayout.TextArea(todoString, GUILayout.MinHeight(position.height));
        
        SaveChanges();
    }


    public void Save() => EditorPrefs.SetString("editorTodoString", todoString);
}

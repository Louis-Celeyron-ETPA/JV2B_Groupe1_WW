using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


[CustomEditor(typeof(MySceneManager))]
public class MySceneManagerEditor : Editor
{
    private SerializedProperty _ddSP;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Generate Dropdown"))
        {
            _ddSP = serializedObject.FindProperty("dropdown");
            var _dd = (_ddSP.objectReferenceValue as Dropdown);
            _dd.ClearOptions();
            foreach (var scene in EditorBuildSettings.scenes)
            {
                _dd.options.Add(new Dropdown.OptionData( AssetDatabase.LoadAssetAtPath<SceneAsset>(scene.path).name));
            }
            serializedObject.ApplyModifiedProperties();
        }


    }
}

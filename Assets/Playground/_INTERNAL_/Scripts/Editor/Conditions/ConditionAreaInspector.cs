﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(ConditionArea))]
public class ConditionAreaInspector : ConditionInspectorBase
{
    //private string explanation = "Perform actions when a GameObject enters, exits, or stays inside the trigger collider (in this last case you get to choose the frequency).";
    private string explanation = "トリガーに侵入したり、トリガーから出たり、トリガーの範囲内に留まっている時に指定した Action を実行する。範囲内に留まっている時に Action を実行する場合は、実行頻度を指定する。";

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        chosenTag = serializedObject.FindProperty("filterTag").stringValue;

        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        // Show a tag selector to then use for the public property filterTag
        GUILayout.Space(10);
        DrawTagsGroup();


        //discern the event type, and show the frequency if needed
        EditorGUILayout.PropertyField(serializedObject.FindProperty("eventType"));
        int eventType = serializedObject.FindProperty("eventType").intValue;
        if (eventType == 2)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("frequency"));
        }

        GUILayout.Space(10);
        DrawActionLists();

        CheckIfTrigger(true);

        if (GUI.changed)
        {
            serializedObject.FindProperty("filterTag").stringValue = chosenTag;
            serializedObject.ApplyModifiedProperties();
        }
    }
}
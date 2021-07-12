using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Angles))]
public class AngleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Angles script = (Angles)target;
        GUILayout.Label(script.GetAngles());
    }
}
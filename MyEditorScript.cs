[CustomEditor(typeof(MyScript))]

public class MyScriptEditor : Editor
{
    public override void OnInspectorGui()
    {
        MyScript script = (MyScript)target;
        script.myVariable = EditorGUILayoutt.IntSlider("Variable", script.myVariable, 0, 100);

        DrawDefaultInspector();
    }
}

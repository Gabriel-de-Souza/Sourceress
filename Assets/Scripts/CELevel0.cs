using UnityEngine;
using System.Collections;

public class CELevel0 : CodeEditorLevel {

    public void EnabledChanged(float i)
    {
        int id = 0;
        Values[id] = i == 1f ? "true" : "false";
		CodeEditor.ValueChanged();
    }
}

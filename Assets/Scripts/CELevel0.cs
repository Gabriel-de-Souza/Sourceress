using UnityEngine;
using System.Collections;

public class CELevel0 : CodeEditorLevel {

    public void EnabledChanged(float i)
    {
        int id = 0;
        values[id] = i == 1f ? "true" : "false";
    }
}

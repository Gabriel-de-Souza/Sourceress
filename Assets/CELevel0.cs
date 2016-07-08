using UnityEngine;
using System.Collections;

public class CELevel0 : CodeEditorLevel {

	public void WidthChanged(float i)
    {
        int id = 1;
        values[id] = Mathf.Round(float.Parse(defaultValues[id]) + (float.Parse(maxValues[id]) - float.Parse(defaultValues[id])) * i).ToString();
    }

    public void HeightChanged(float i)
    {
        int id = 0;
        values[id] = Mathf.Round(float.Parse(defaultValues[id]) + (float.Parse(maxValues[id]) - float.Parse(defaultValues[id])) * i).ToString();
    }
}

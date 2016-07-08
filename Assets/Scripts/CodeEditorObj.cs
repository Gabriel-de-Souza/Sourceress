using UnityEngine;

public class CodeEditorObj : MonoBehaviour {
    [SerializeField]
    private int level = 0;
	// Update is called once per frame
	void OnMouseUp () {
        CodeEditor.ShowLevel(level);
	}
}

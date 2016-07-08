using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CodeEditor : MonoBehaviour {

    private static CodeEditor instance = null;

    [SerializeField]
    private GameObject fade;

    [SerializeField]
    private GameObject closedBook;

    [SerializeField]
    private GameObject openBook;

    [SerializeField]
    private CodeEditorLevel[] levels;

    private CodeEditorLevel currentLevel = null;

    public static string[] Values
    {
        get
        {
            if (instance == null)
                return null;
            else
                return instance.currentLevel.values;
        }
    }

	public void Show(int level)
    {
        fade.SetActive(true);
        closedBook.SetActive(true);
        openBook.gameObject.SetActive(false);
        if (level > 0 && level < levels.Length)
            currentLevel = levels[level];
    }

    public void Book_Open()
    {
        closedBook.SetActive(false);
        openBook.gameObject.SetActive(true);
        if (currentLevel != null)
            currentLevel.gameObject.SetActive(true);
    }

    public void Close()
    {
        if (currentLevel != null)
        {
            currentLevel.gameObject.SetActive(false);
            currentLevel = null;
        }
        fade.SetActive(false);
    }
}

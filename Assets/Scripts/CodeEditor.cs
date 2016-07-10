using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

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

	public static List<Action<string[]>> OnValueChanged = new List<Action<string[]>>();

	public static void ValueChanged(){
		if (instance != null)
		{
			foreach (Action<string[]> ac in OnValueChanged)
			{
				if (ac != null)
					ac(Values);
			}
		}
	}

    public static string[] Values
    {
        get
        {
            if (instance == null)
                return null;
            else
                return instance.currentLevel.Values;
        }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public static void ShowLevel(int level)
    {
        if (instance != null)
            instance.Show(level);
    }

	public void Show(int level)
    {
        fade.SetActive(true);
        closedBook.SetActive(true);
        openBook.gameObject.SetActive(false);
        if (level >= 0 && level < levels.Length)
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

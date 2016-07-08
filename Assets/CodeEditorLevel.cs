using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CodeEditorLevel : MonoBehaviour {

    [SerializeField]
    protected Text leftPage;
    protected string leftPageDefault;

    [SerializeField]
    protected Text rightPage;
    protected string rightPageDefault;

    public string[] values;
    protected string[] defaultValues;
    [SerializeField]
    protected string[] maxValues;

    void Start()
    {
        leftPageDefault = leftPage.text;
        rightPageDefault = rightPage.text;
        defaultValues = (string[])values.Clone();
    }

    void Update()
    {
        leftPage.text = leftPageDefault;
        rightPage.text = rightPageDefault;
        for (int i = 0; i < values.Length; i++)
        {
            leftPage.text = leftPage.text.Replace("$" + i + "%", values[i]);
            rightPage.text = rightPage.text.Replace("$" + i + "%", values[i]);
        }
    }
}

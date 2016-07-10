using UnityEngine;
using System.Collections;

public class Totem : MonoBehaviour {

	[SerializeField]
	private Animator[] animator;
	[SerializeField]
	private Light light;
	[SerializeField]
	private GameObject particleSystem;

	private bool isActivated = false;
	void Start () {
		Activate(isActivated);
		CodeEditor.OnValueChanged.Add(OnValueChanged);
	}

	void OnDestroy(){
		CodeEditor.OnValueChanged.Remove(OnValueChanged);
	}
	
	void Activate(bool state){
		light.enabled = state;
		foreach (Animator an in animator)
		{
			an.SetBool("IsActivated", state);
		}
		particleSystem.SetActive(state);
		isActivated = state;
	}

	void OnValueChanged(string[] str){
		Activate(str[0].Equals("true") ? true : false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButton()
	{
		Debug.Log("SceneA Button is pushed.");

		SceneController scnCtrl = SceneController.instance;
		Animator anim = scnCtrl.GetComponentInChildren<Animator>();
		anim.SetBool("IsFadeOut", true);
		anim.SetBool("IsFadeIn", false);
		StartCoroutine("waitFadeOut");
	}

	IEnumerator waitFadeOut()
	{
		yield return new WaitForSeconds(2);

		Application.LoadLevel("SceneB");
		SceneController scnCtrl = SceneController.instance;
		Animator anim = scnCtrl.GetComponentInChildren<Animator>();
		anim.SetBool("IsFadeIn", true);
		anim.SetBool("IsFadeOut", false);
	}
}

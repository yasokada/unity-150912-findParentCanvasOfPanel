using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FindParentCanvas : MonoBehaviour {
	
	string getMyParentCanvasName(GameObject panel) {
		// 1. one upper
		GameObject parentGO = panel.transform.parent.gameObject;
		if (parentGO.GetComponent<Canvas> () != null) {
			return parentGO.name;
		}
			       
		// 2. two uppers
		GameObject grandParentGO = parentGO.transform.parent.gameObject;
		if (grandParentGO.GetComponent<Canvas> () != null) {
			return grandParentGO.name;
		}

		return ""; // not found
	}

	void Start () {
		GameObject myPanel;

		myPanel = GameObject.Find ("Panel_1_1");
		string canvasNams = getMyParentCanvasName (myPanel);
		Debug.Log (canvasNams + " is parent canvas of " + myPanel.name);
	}	
}

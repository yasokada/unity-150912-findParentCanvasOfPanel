using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 * v0.3 2015/09/15
 *   - add null case handling for GetComponentInParent()
 * v0.2 2015/09/15
 *   - brush up getMyParentCanvasName() by using GetComponentInParent()
 * v0.1 2015/09/12
 *   - getMyParentCanvasName() worked as expected 
 */

public class FindParentCanvas : MonoBehaviour {
	
	string getMyParentCanvasName(GameObject panel) {
		Canvas canvasGO = panel.GetComponentInParent<Canvas> ();
		if (canvasGO != null) {
			return canvasGO.name;
		} else {
			return "";
		}
	}

	void Test_each(string name) {
		GameObject myPanel = GameObject.Find (name);
		string canvasName = getMyParentCanvasName (myPanel);
		Debug.Log (canvasName + " - " + myPanel.name);
	}

	void Test_main() {
		Test_each ("Panel_1");
		Test_each ("Panel_1_1");
		Test_each ("Panel_1_2_1");

		Test_each ("Panel_2");
		Test_each ("Panel_2_1");
		Test_each ("Panel_2_2_1");

		Test_each ("Panel_3"); // for null case
	}


	void Start () {
		Test_main ();
	}	
}

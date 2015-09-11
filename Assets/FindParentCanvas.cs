using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 * v0.1 2015/09/12
 *   - getMyParentCanvasName() worked as expected 
 */

public class FindParentCanvas : MonoBehaviour {
	
	string getMyParentCanvasName(GameObject panel) {
		GameObject parentGO;
		GameObject targetGO = panel;

		for (int loop=0; loop<3; loop++) { // search upper three levels
			parentGO = targetGO.transform.parent.gameObject;
			if (parentGO.GetComponent<Canvas> () != null) {
				return parentGO.name;
			}
			targetGO = parentGO;
		}
		return "";
	}

	void Test_each(string name) {
		GameObject myPanel;
		string canvasName;
		
		// case 1
		myPanel = GameObject.Find (name);
		canvasName = getMyParentCanvasName (myPanel);
		Debug.Log (canvasName + " - " + myPanel.name);
	}

	void Test_main() {
		Test_each ("Panel_1");
		Test_each ("Panel_1_1");
		Test_each ("Panel_1_2_1");

		Test_each ("Panel_2");
		Test_each ("Panel_2_1");
		Test_each ("Panel_2_2_1");
	}


	void Start () {
		Test_main ();
	}	
}

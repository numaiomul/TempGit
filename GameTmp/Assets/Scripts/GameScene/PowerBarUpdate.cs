using UnityEngine;
using UnityEngine.UI;
public class PowerBarUpdate : MonoBehaviour {

	public Transform powerBar;

	public Image bar1,bar2;
	
	// Update is called once per frame
	void Update () {
		bar1.fillAmount = powerBar.localPosition.x;
		bar2.fillAmount = powerBar.localPosition.x;
	}
}

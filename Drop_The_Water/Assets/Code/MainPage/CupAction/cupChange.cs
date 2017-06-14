using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		Vector3 direction = this.transform.position;
		Debug.Log (direction);
		Vector3 direction_water = new Vector3(0, 8, 0);


		if(other.gameObject.tag.Equals("waterdrop"))
		{
			Debug.Log ("destroy" + other.gameObject.tag);
			GameObject changecup = GameObject.Find("cup_0");


			if (this.gameObject.CompareTag ("cup_0")) {
				changecup = GameObject.Find ("cup_1");
			}else if (this.gameObject.CompareTag ("cup_1")) {
				changecup = GameObject.Find ("cup_2");
			}else if (this.gameObject.CompareTag ("cup_2")) {
				changecup = GameObject.Find ("cup_3");
			}else if (this.gameObject.CompareTag ("cup_3")) {
				changecup = GameObject.Find ("cup_4");
			}else if (this.gameObject.CompareTag ("cup_4")) {
				changecup = GameObject.Find ("cup_5");
			}else if (this.gameObject.CompareTag ("cup_5")) {
				changecup = GameObject.Find ("cup_6");
			}else if (this.gameObject.CompareTag ("cup_6")) {
				changecup = GameObject.Find ("cup_7");
			}else if (this.gameObject.CompareTag ("cup_7")) {
				changecup = GameObject.Find ("cup_8");
			}

			Debug.Log ("changecup" + changecup.tag);
			changecup.transform.position = direction;
			Destroy(this.gameObject);
			other.transform.position = direction_water;
			
		}
	}
}
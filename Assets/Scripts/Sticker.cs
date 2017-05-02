using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticker : OVRGrabbable {

	public GameObject graphics;

	public override void Init(){
		
	}

	void Update(){
		if (isGrabbed){
			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
				graphics.transform.position = hit.point + hit.normal;
				graphics.transform.rotation = Quaternion.LookRotation (-hit.normal);
				graphics.transform.localScale = Vector3.one * 8;
			} else {
				graphics.transform.localPosition = Vector3.zero;
				graphics.transform.localRotation = Quaternion.identity;
				graphics.transform.localScale = Vector3.one;
			}
		}
	}

}

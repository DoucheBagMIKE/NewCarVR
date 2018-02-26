using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ResetCar : MonoBehaviour {

    VRTK_ControllerEvents leftHand;
    VRTK_ControllerEvents rightHand;

    public GameObject ObjToReset;

    Vector3 startLoc;
    Quaternion startRot;

    // Use this for initialization
    void Awake ()
    {
        leftHand = VRTK_SDKManager.instance.scriptAliasLeftController.GetComponent<VRTK_ControllerEvents>();
        rightHand = VRTK_SDKManager.instance.scriptAliasRightController.GetComponent<VRTK_ControllerEvents>();

        startLoc = ObjToReset.transform.position;
        startRot = ObjToReset.transform.rotation;

    }
	
	void Update ()
    {
        if(leftHand.touchpadPressed || rightHand.touchpadPressed)
        {
            ObjToReset.transform.position = startLoc;
            ObjToReset.transform.rotation = startRot;
        }
		
	}
}

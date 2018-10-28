using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour {


    private Transform transformCamera;
    private Transform transformPivot;
    private Vector3 LocalRotation;

    //Constant to adjust camera distance 
    private float currentCameraDist = 6f;
    private readonly float minCameraDist = 3f;
    private readonly float maxCameraDist = 15f;

    //Constants to adjust Scroll/Orbit Sensitivity 
    public readonly float mouseSensitivity = 8f;
    public readonly float scrollSensitivity = 2f;
    public readonly float orbitDampening = 10f;
    public readonly float scrollDampening = 6f;

   



    // Use this for initialization
    void Start () {

        this.transformCamera = this.transform;
        this.transformPivot = this.transform.parent;

    }

    // Update is called once per frame
    void LateUpdate () {
    
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        bool mouseClicked = Input.GetMouseButton(0);

        if (mouseClicked && (mouseX != 0 || mouseY != 0))
        {
            //rotate camera
            LocalRotation.x += mouseX * mouseSensitivity;
            LocalRotation.y -= mouseY * mouseSensitivity;

            //limit y-axis rotation angle so it doesnt flip the skull over
            LocalRotation.y = Mathf.Clamp(LocalRotation.y, -90f, 90f);
        }


        if (mouseScroll != 0f)
        {
            //zoom functionality
            float scrollAmount = mouseScroll * scrollSensitivity;
            this.currentCameraDist += scrollAmount * -1f;
            this.currentCameraDist = Mathf.Clamp(this.currentCameraDist, minCameraDist, maxCameraDist);

        }

        //update position
        Quaternion QT = Quaternion.Euler(LocalRotation.y, LocalRotation.x,0);
        this.transformPivot.rotation = Quaternion.Lerp(this.transformPivot.rotation, QT, Time.deltaTime * orbitDampening);
        this.transformCamera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this.transformCamera.localPosition.z, this.currentCameraDist * -1f, Time.deltaTime * scrollDampening));
     

	}


}

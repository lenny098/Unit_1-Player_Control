using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera thirdPerson;
    public Camera firstPerson;

    public bool showFirstPerson = false;
    public bool isPlayer2 = false;

    void setCamera()
    {
        thirdPerson.enabled = !showFirstPerson;
        firstPerson.enabled = showFirstPerson;
    }

    // Start is called before the first frame update
    void Start()
    {
        setCamera();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(isPlayer2 ? KeyCode.RightControl : KeyCode.LeftControl))
        {
            showFirstPerson = !showFirstPerson;

            setCamera();
        }
    }
}

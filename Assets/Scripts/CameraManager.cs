using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera firstPerson;
    
    Camera thirdPerson;
    [SerializeField] Vector3 thirdPersonOffset = new Vector3(0, 13, -14);
    [SerializeField] Vector3 thirdPersonRotation = new Vector3(30, 0, 0);

    [SerializeField] KeyCode switchKey;

    bool showFirstPerson = false;

    void initailzeThirdPersonCamera()
    {
        GameObject cameraObject = new GameObject();
        cameraObject.name = $"Third Person Camera of {gameObject.name}";

        thirdPerson = cameraObject.AddComponent<Camera>();
        thirdPerson.rect = firstPerson.rect;
        thirdPerson.transform.eulerAngles = thirdPersonRotation;
    }

    void setCameras()
    {
        thirdPerson.enabled = !showFirstPerson;
        firstPerson.enabled = showFirstPerson;
    }

    // Start is called before the first frame update
    void Start()
    {
        initailzeThirdPersonCamera();
        setCameras();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            showFirstPerson = !showFirstPerson;
            setCameras();
        }
    }

    // Use LateUpdate to make sure the camera always moves after player and npc
    void LateUpdate()
    {
        // follow player with an offset
        thirdPerson.transform.position = gameObject.transform.position + thirdPersonOffset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerAlt : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset; // 0, 2, 5
    public Vector3 rotate; // 0, 0, 0

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.eulerAngles = rotate;

        transform.RotateAround(
            player.transform.position,
            Vector3.up,
            player.transform.eulerAngles.y
        );
    }
}

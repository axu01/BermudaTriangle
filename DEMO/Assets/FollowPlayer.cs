using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform cube;

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.transform.position + new Vector3(0, 1, -4);

    }

}

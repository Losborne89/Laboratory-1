using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0f, 8, -20);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
    }
}

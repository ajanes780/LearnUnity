using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;
    private readonly Vector3 _offset = new Vector3(0, 5, -10);
    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}

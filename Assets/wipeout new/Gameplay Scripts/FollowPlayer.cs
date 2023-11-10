using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform _player;

    private void Update()
    {
        transform.position = _player.transform.position + new Vector3(0, 5, -7);
    }

}

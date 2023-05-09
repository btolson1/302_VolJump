/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Camera Follower Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _smoothSpeed = 5f;

    private Vector3 _endPos;
    public bool _canFollow;

    // Camera is only going to go up as the player goes up
    private void FixedUpdate()
    {
        if (!_canFollow) return;
        if (transform.position.y >= _endPos.y) return;
        transform.position = Vector3.Slerp(transform.position,_endPos,_smoothSpeed*Time.fixedDeltaTime);
    }

    // if the player falls down, the camera will not follow,
    // and the player will die/lose
    public void UpdateCamera()
    {
        _endPos = transform.position;
        _endPos.y = _target.position.y + 1.5f;
    }
}


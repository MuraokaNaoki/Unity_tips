using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    //public float rotx;
    //public float roty;
    //public float rotz;

    [SerializeField] private Vector3 _center = Vector3.zero;
    [SerializeField] private Vector3 _axis = Vector3.up;
    [SerializeField] private float _period = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(
            _center,
            _axis,
            360 /_period*Time.deltaTime
            );
    }
}

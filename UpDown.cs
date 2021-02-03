using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    Vector3 objPosition;
    public float moveSpped;
    // Start is called before the first frame update
    void Start()
    {
        objPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(objPosition.x, Mathf.Cos(Time.time)*moveSpped + objPosition.y, objPosition.z);
    }
}

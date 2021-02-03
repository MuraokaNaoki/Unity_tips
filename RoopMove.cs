using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class RoopMove : MonoBehaviour
{
    public float startPosx;
    public float startPosz;
    public float endPosx;
    public float endPosz;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool m_xPlus = true;//x座標の始点(スタート)
    bool m_zPlus = false;//z座標の始点
    bool m_x2Plus = false;//x座標の終点
    bool m_z2Plus = false;//z座標の終点

    // Update is called once per frame
    void Update()
    {
        //始点と終点の真偽値を切り替えて、動きを変える
        if (m_xPlus)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
            if(transform.position.x >= endPosx)
            {
                //Thread.Sleep(1000);
                m_xPlus = false;
                m_zPlus = true;
            }
        }

        if (m_zPlus)
        {
            transform.position += new Vector3(0f, 0f, moveSpeed * Time.deltaTime);
            if(transform.position.z >= endPosz)
            {
                //Thread.Sleep(1000);
                m_zPlus = false;
                m_x2Plus = true;
            }
        }

        if (m_x2Plus)
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f);
            if(transform.position.x <= startPosx)
            {
                //Thread.Sleep(1000);
                m_x2Plus = false;
                m_z2Plus = true;
            }
        }

        if (m_z2Plus)
        {
            transform.position += new Vector3(0f, 0f, -moveSpeed * Time.deltaTime);
            if(transform.position.z <= startPosz)
            {
                //Thread.Sleep(1000);
                m_z2Plus = false;
                m_xPlus = true;
            }
        }
    }
}

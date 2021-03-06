﻿using UnityEngine;
using System.Collections;
using System;

public class CameraTrace : MonoBehaviour
{
    private GameObject player;
    Vector3 nowPos;

    Vector3 offset;
    void Start()
    {
        player = GameObject.Find("Player"); //プレイヤーを取得
        //自分から見た相手の位置
        offset = transform.position - player.transform.position;
    }


    void Update()
    {
        //playerの位置情報を監視
        Vector3 targetCamPos = player.transform.position + offset;
        if ( transform.position.x < targetCamPos.x ) {
            transform.position = Vector3.Lerp(transform.position ,
                new Vector3(targetCamPos.x , transform.position.y , transform.position.z) ,
                10 * Time.deltaTime);
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        //전달된 다른 개체의 정보
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            //스크립트가 부착된 게임 개체의 정보
            gameObject.tag = "Hit";
        }
    }
}

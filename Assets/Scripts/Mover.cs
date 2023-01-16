using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //SerializeField Inspector에서 변수값 실시간 변경 가능. 그러나 Inspector변수값이 실제 변수값에 오버라이딩 되지는 않음.
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        //Input Manager의 축값을 가져와 키에 따라 -1, +1값 적용.
        //Time.deltaTime: 프레임 실행 시 걸리는 시간을 알려줌(CPU에 따른 차이 존재)
        //Frames per second * Distance per Second을 통해 frame rate로부터 독립.
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }

    //cinemachine Brain: 가상 카메라중 어떤 카메라를 메인 카메라로 잡을지 결정.
}

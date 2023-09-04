using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public Stat()
    {
        Debug.Log("Stat 생성");
    }
}

public class Monster : MonoBehaviour
{
    Stat stat;

    // Awake : 스크립트가 실행될 때 단 한번만 호출되며, 스크립트가
    // 비활성화 되어도 실행되는 이벤트 함수입니다.

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable : 게임 오브젝트가 활성화 될 떄마다 호출되는 이벤트 함수입니다.

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start : 스크립트가 실행될 때 단 한번만 호출되며, 스크립트가
    // 비활성화 상태일 땐 실행되지 않는 이벤트 함수입니다.

    void Start()
    {
        stat = new Stat();
        Debug.Log("Start");
    }

    // FixedUpdate : Timestep 설정된 값에 따라 일정한 주기로
    // 호출되는 이벤트 함수입니다.

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Update : 매 프레임마다 호출되는 이벤트 함수이며, 디바이스의 성능이나
    // 최적화 상황에 따라 프레임 레이트가 변화하므로 함수 호출 시간이 계속 달라집니다.

    void Update()
    {
        Debug.Log("Update");
    }

    // LateUpdate : Update 함수가 호출된 후에 호출되는 이벤트 함수입니다.

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    // OnDisable : 게임 오브젝트가 비활성화 되었을 때 호출되는 이벤트 함수입니다.

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // OnDestroy : 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수입니다.

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linemanager : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetupLine(Transform[] points)
    {
        this.points = points;
        lr.positionCount = points.Length;

        // 초기 위치 설정
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }

    private void Update()
    {
        // 매 프레임마다 점들의 위치를 갱신하여 라인을 업데이트
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}

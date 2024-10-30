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

        // �ʱ� ��ġ ����
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }

    private void Update()
    {
        // �� �����Ӹ��� ������ ��ġ�� �����Ͽ� ������ ������Ʈ
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    private Vector3 StartPoint, EndPoint;
    public GameObject[] _Nodes;
    public int NodeCount;

    void Awake()
    {
        StartPoint = new Vector3(-1500f,-840f,0);
        EndPoint = new Vector3(1500f, 840f, 0);
        CreatNode();
    }

    public void CreatNode()
    {
        for (int i = 0; i < NodeCount; i++)
        {
            GameObject temp = Instantiate(_Nodes[Random.Range(0, _Nodes.Length)]) as GameObject;
            Vector3 v = new Vector3(Random.Range(StartPoint.x, EndPoint.x), Random.Range(StartPoint.y, EndPoint.y), 0);
            temp.transform.parent = transform;
            transform.position = v;
        }
    }
}

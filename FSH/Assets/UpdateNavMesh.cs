using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UpdateNavMesh : MonoBehaviour
{
    NavMeshSurface nm;

    // Start is called before the first frame update
    void Start()
    {
        nm = GameObject.FindObjectOfType<NavMeshSurface>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlaneFound()
    {
        nm.BuildNavMesh();         Debug.Log("FOUND!");     }
}

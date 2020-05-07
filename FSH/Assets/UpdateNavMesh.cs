using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UpdateNavMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlaneFound()
    {         NavMeshSurface nm = GameObject.FindObjectOfType<NavMeshSurface>();
        nm.BuildNavMesh();         Debug.Log("FOUND!");     }
}

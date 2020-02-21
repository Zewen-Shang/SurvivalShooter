using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ToolsManager : MonoBehaviour
{
    
    public Transform[] positions;

    public GameObject[] tools;

    public float intervalTime = 1f;

    float timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= intervalTime){
            Random ran=new Random();
            int ToolIndex=Random.Range(0,3);
            int positionIndex = Random.Range(0,6);
            Vector3 newPos = positions[positionIndex].position;
            newPos.x += Random.Range(-5f,5f);
            newPos.z += Random.Range(-5f,5f);
            Instantiate(tools[ToolIndex],newPos,new Quaternion());
            timer = 0;
        }
    }
}

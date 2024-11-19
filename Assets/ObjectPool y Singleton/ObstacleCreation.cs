using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreation : MonoBehaviour
{
    
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1, 1);
    }



    private void CreateObstacle()
    {
        GameObject obstacle = ObjectPool.instance.GetObstacle();
        obstacle.transform.position = transform.position;
        obstacle.SetActive(true);
    }
}

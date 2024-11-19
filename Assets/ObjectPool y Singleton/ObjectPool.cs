using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private List<GameObject> objects;
    [SerializeField] private int amountToPool;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }

    void Start()
    {
        AddObjectsToPool(amountToPool);
    }



    private void AddObjectsToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            obstacle.SetActive(false);
            objects.Add(obstacle);

            obstacle.transform.parent = transform;
        }
    }

    public GameObject GetObstacle()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!objects[i].activeSelf)
            {
                return objects[i];
            }
        }
        return null;
    }
}

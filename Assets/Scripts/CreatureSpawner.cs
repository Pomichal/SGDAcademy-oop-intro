using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{

    [SerializeField]
    private Creature creaturePrefab;
    [SerializeField]
    private int creatureCount;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < creatureCount; i++)
        {
            Creature inst = Instantiate(creaturePrefab, GetRandomPos(), Quaternion.identity);
        }
    }

    private Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(-10, 10f), 1, Random.Range(-10, 10f));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneMaker : MonoBehaviour
{
    public GameObject[] bonePrefab;   // 뼈의 종류를 저장한다.
    public Transform[] boneSpawnPos;  // 뼈가 생성될 위치를 정한다.

    public float spawnTime = 0.5f; // 뼈가 생성될 주기
    private float TimeCheck;
    // Update is called once per frame
    void Update()
    {
        TimeCheck -= Time.deltaTime;

        if (TimeCheck <= 0)
        {
            int RandomBone = UnityEngine.Random.Range(0, bonePrefab.Length);
            int RandomPos = UnityEngine.Random.Range(0, boneSpawnPos.Length);

            Instantiate(bonePrefab[RandomBone], boneSpawnPos[RandomPos].position, Quaternion.identity);
            TimeCheck = spawnTime;
        }
    }
}

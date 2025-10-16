using UnityEngine;
using System.Collections.Generic;

public class NPCFactory : MonoBehaviour
{
    public GameObject shopownerPrefab;
    public GameObject beggarPrefab;
    public GameObject farmerPrefab;
    public GameObject knightPrefab;

    private List<Transform> spawnPoints = new List<Transform>();
    public Transform spawnPointContainer;

    private void Start()
    {
        for (int i = 0; i < spawnPointContainer.childCount; i++)
        {
            spawnPoints.Add(spawnPointContainer.GetChild(i));
        }
    }

    public INPC GetNPC(NPCType type)
    {
        GameObject prefab = null;

        switch (type)
        {
            case NPCType.Beggar:
                prefab = beggarPrefab;
                break;
            case NPCType.Farmer:
                prefab = farmerPrefab;
                break;
            case NPCType.Shopowner:
                prefab = shopownerPrefab;
                break;
            case NPCType.Knight:
                prefab = knightPrefab;
                break;
        }

        if (prefab == null)
        {
            Debug.LogError("Prefab not assigned!");
            return null;
        }

        int spawnPoint = Random.Range(0, spawnPoints.Count);
        Vector3 position = spawnPoints[spawnPoint].position;

        GameObject enemyGO = Instantiate(prefab, position, Quaternion.identity);
        return enemyGO.GetComponent<INPC>();
    }
}

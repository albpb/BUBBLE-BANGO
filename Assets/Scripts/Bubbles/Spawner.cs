using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Spawner : MonoBehaviour
{
    private Collider2D spawnArea;

    public GameObject[] bubblesPrefabs;
    public float[] spawnProbabilities;

    public float minSpawnDelay = 0.25f;
    public float maxSpawnDelay = 1f;

    private void Awake()
    {
        spawnArea = GetComponent<Collider2D>();

        if (spawnProbabilities.Length != bubblesPrefabs.Length)
        {
            Debug.LogError("The number of probabilities must match the number of bubble prefabs.");
        }
    }

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);

        while (enabled)
        {
            GameObject prefab = SelectBubbleBasedOnProbability();

            Vector3 position = new Vector3
            {
                x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
                y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
                z = 0
            };

            GameObject bubble = Instantiate(prefab, position, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }

    private GameObject SelectBubbleBasedOnProbability()
    {
        float totalProbability = 0f;
        foreach (float probability in spawnProbabilities)
        {
            totalProbability += probability;
        }

        float randomValue = Random.Range(0f, totalProbability);

        float cumulativeProbability = 0f;

        for (int i = 0; i < spawnProbabilities.Length; i++)
        {
            cumulativeProbability += spawnProbabilities[i];

            if (randomValue <= cumulativeProbability)
            {
                return bubblesPrefabs[i];
            }
        }

        return bubblesPrefabs[bubblesPrefabs.Length - 1];
    }
}

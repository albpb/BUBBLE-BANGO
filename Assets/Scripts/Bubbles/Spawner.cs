using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Spawner : MonoBehaviour
{
    private Collider2D spawnArea;

    public GameObject[] bubblesPrefabs;

    public float minSpawnDelay = 0.25f;
    public float maxSpawnDelay = 1f;

   // public float maxLifetime = 5f;

    private void Awake()
    {
        spawnArea = GetComponent<Collider2D>();
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
            GameObject prefab = bubblesPrefabs[Random.Range(0, bubblesPrefabs.Length)];

            Vector3 position = new Vector3
            {
                x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
                y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
                z = 0
            };

            // Error: necesita rotation
            GameObject bubble = Instantiate(prefab, position, Quaternion.identity);
        //    Destroy(bubble, maxLifetime);


            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }

}
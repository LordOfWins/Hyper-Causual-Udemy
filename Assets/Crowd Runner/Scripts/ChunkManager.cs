using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Chunk[] chunkPrefabs;

     void Start()
    {
        Vector3 position = Vector3.zero;

        for (int i = 0; i < 5; i++)
        {
            Chunk prefab = chunkPrefabs[Random.Range(0, chunkPrefabs.Length)];
if(i>0) position.z += prefab.GetChunkSize()/2;
            Chunk chunk = Instantiate(prefab, position, Quaternion.identity, transform);
            position.z += chunk.GetChunkSize()/2;

        }
    }

    // 추후 업데이트 로직 구현 예정
     void Update()
    {
    }
}

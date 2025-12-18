using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [header("Chunk Manager")]
    [SerializeField] private Chunk chunkPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // for (int i = 0; i < 5; i++)
        // {
        //     Vector3 chunkPosition = Vector3.zero; //설명: 청크의 위치를 0,0,0으로 설정
        //     chunkPosition.z = i * 15;
        //     Instantiate(chunkPrefabs, chunkPosition, Quaternion.identity, transform); //설명: 청크를 생성하고 위치를 설정
        // }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

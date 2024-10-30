using UnityEngine;

public class Spawnright : MonoBehaviour
{
    public GameObject[] fishPrefabs;       // 다양한 물고기 프리팹 배열
    public float spawnInterval = 2.0f;     // 스폰 간격
    public float spawnPositionX = 7.5f;    // 고정된 X 좌표 (오른쪽 위치)
    public float spawnRangeYMin = -3.0f;   // Y 좌표 최소값
    public float spawnRangeYMax = 3.0f;    // Y 좌표 최대값

    private void Start()
    {
        // 지정된 간격으로 물고기 생성
        InvokeRepeating(nameof(SpawnFish), 1.0f, spawnInterval);
    }

    void SpawnFish()
    {
        // 랜덤으로 프리팹 선택
        int randomIndex = Random.Range(0, fishPrefabs.Length);
        GameObject selectedPrefab = fishPrefabs[randomIndex];

        // Y 축에서 랜덤 위치 생성
        float randomY = Random.Range(spawnRangeYMin, spawnRangeYMax);

        // X 축에서 약간의 랜덤 오차 추가
        float offsetX = Random.Range(-0.3f, 0.3f); // ±0.3f의 변동으로 겹침 최소화
        Vector2 spawnPosition = new Vector2(spawnPositionX + offsetX, randomY);

        // 선택된 물고기 프리팹 생성
        Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Vector3 spawnCenter = new Vector3(spawnPositionX, (spawnRangeYMin + spawnRangeYMax) / 2, 0);
        Vector3 spawnSize = new Vector3(0.5f, spawnRangeYMax - spawnRangeYMin, 0);
        Gizmos.DrawWireCube(spawnCenter, spawnSize);
    }
}
    
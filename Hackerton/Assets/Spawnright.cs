using UnityEngine;

public class Spawnright : MonoBehaviour
{
    public GameObject[] fishPrefabs;       // �پ��� ����� ������ �迭
    public float spawnInterval = 2.0f;     // ���� ����
    public float spawnPositionX = 7.5f;    // ������ X ��ǥ (������ ��ġ)
    public float spawnRangeYMin = -3.0f;   // Y ��ǥ �ּҰ�
    public float spawnRangeYMax = 3.0f;    // Y ��ǥ �ִ밪

    private void Start()
    {
        // ������ �������� ����� ����
        InvokeRepeating(nameof(SpawnFish), 1.0f, spawnInterval);
    }

    void SpawnFish()
    {
        // �������� ������ ����
        int randomIndex = Random.Range(0, fishPrefabs.Length);
        GameObject selectedPrefab = fishPrefabs[randomIndex];

        // Y �࿡�� ���� ��ġ ����
        float randomY = Random.Range(spawnRangeYMin, spawnRangeYMax);

        // X �࿡�� �ణ�� ���� ���� �߰�
        float offsetX = Random.Range(-0.3f, 0.3f); // ��0.3f�� �������� ��ħ �ּ�ȭ
        Vector2 spawnPosition = new Vector2(spawnPositionX + offsetX, randomY);

        // ���õ� ����� ������ ����
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
    
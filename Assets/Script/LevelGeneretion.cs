using UnityEngine;

public class LevelGeneretion : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FPlatformPrefabs;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float DistanceBetweenPlatforms;

    public Transform FinishPlanform;


    private void Awake()
    {
        int plaformsCount = Random.Range(MinPlatforms, MaxPlatforms + 1);

        for (int i = 0; i < plaformsCount; i++)
        {
            int prefabIndex = Random.Range(0, PlatformPrefabs.Length);

            GameObject platformPrefab = i == 0 ? FPlatformPrefabs : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = Calculat(i);
            platform.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }

        FinishPlanform.position = Calculat(plaformsCount);
    }

    private Vector3 Calculat(int platformIndex)
    {
        return new Vector3(0, -DistanceBetweenPlatforms * platformIndex, 0);
    }
}

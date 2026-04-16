using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject[] enemySpawnNodes;
    public GameObject[] enemies;

    public int killCount = 0;
    public int firstBatchEnemyCount = 3;

    public int killsToWin = 4;

    public SceneChanger sceneChanger;

    public GameObject bloodEffectPrefab;

    public bool isBossSpawned = false;

    public void WinTime()
    {
        SceneData.instance.kingArthurSceneVisited = true;
        sceneChanger.ChangeSceneAsync();
    }

    public void SwordPickup()
    {
        for (int i = 0; i < firstBatchEnemyCount; i++)
        {
            EnableEnemies(i);
        }
    }

    private void EnableEnemies(int enemyIndex)
    {
        enemies[enemyIndex].transform.localPosition = enemySpawnNodes[enemyIndex].transform.localPosition;
        enemies[enemyIndex].transform.localRotation = enemySpawnNodes[enemyIndex].transform.localRotation;

        // Should grab first Particle System (puff of smoke)
        ParticleSystem particleSystem = enemies[enemyIndex].GetComponentInChildren<ParticleSystem>();
        particleSystem.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Enemy enemyScript = other.gameObject.GetComponent<Enemy>();

            // Should grab second Particle system (blood spray)
            GameObject bloodEffect = Instantiate(bloodEffectPrefab, other.transform.position, Quaternion.identity);

            if (isBossSpawned == true)
            {
                bloodEffect.transform.localScale *= 2f;
            }

            enemyScript.enemyHealth -= 1;

            if (enemyScript.enemyHealth <= 0)
            {
                Destroy(other.gameObject);
                killCount += 1;
            }
            if (killCount == firstBatchEnemyCount && isBossSpawned == false)
            {
                EnableEnemies(firstBatchEnemyCount);
                isBossSpawned = true;
            }
            if (killCount >= killsToWin)
            {
                WinTime();
            }
        }
    }
}
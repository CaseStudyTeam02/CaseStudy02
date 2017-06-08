using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnPoint : MonoBehaviour {

    public EnemySpawnStatus myStatus;//スポーン地点のステータス

    static List<Enemy> EnemyData;//全エネミーのデータ

    public EnemyStruct.ENEMY_MOVETYPE MoveType;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetStatus(EnemySpawnStatus status)
    {
        myStatus = status;
    }

    public void Spawn(Enemy enemy)
    {
        Enemy enemyObj = (Enemy)Instantiate(enemy,transform);
        enemyObj.transform.parent = null;
        enemyObj.SetStatus(MoveType);
    }
}

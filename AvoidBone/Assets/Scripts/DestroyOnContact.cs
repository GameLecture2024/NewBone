using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnContact : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // 게임을 재시작합니다.
            //SceneManager.LoadScene(0);
            // 부딪힌 오브젝트안에서 MoveInput 클래스안에 있는 GameOverMenu를 실행하라.
            collision.gameObject.GetComponent<MoveInput>().GameOverMenu();
        }
        
        Destroy(gameObject);
    }
}

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
            // ������ ������մϴ�.
            //SceneManager.LoadScene(0);
            // �ε��� ������Ʈ�ȿ��� MoveInput Ŭ�����ȿ� �ִ� GameOverMenu�� �����϶�.
            collision.gameObject.GetComponent<MoveInput>().GameOverMenu();
        }
        
        Destroy(gameObject);
    }
}

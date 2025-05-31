using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int buildIndex) // �� ��ȣ�� �ش� ���� �ҷ����� �Լ�
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void GameQuit() // ������ �����ϴ� �Լ�
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
}

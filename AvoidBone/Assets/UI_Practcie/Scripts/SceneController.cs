using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int buildIndex) // 씬 번호로 해당 씬을 불러오는 함수
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void GameQuit() // 게임을 종료하는 함수
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] GameObject screen;
    [SerializeField] Image progressUI;

    public void NextScene()
    {
        StartCoroutine(LoadScene("Battle Game Scene"));
    }

    private IEnumerator LoadScene(string name)
    {
        screen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(name);

        progressUI.fillAmount = 0;

        // allowSceneActivation : �� �̵��� �����ϴ� ����

        // true = �� �̵�
        // false = �� �̵� ����
        operation.allowSceneActivation = false;

        float progress = 0;

        // isDone : �� �̵��� �� �������� Ȯ���ϴ� �Լ�
        // true = �� �ε� �Ϸ�
        // false = �� �ε� �̿Ϸ�
        while(!operation.isDone)
        {
            progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);

            progressUI.fillAmount = progress;

            // 0.9f ���� �� �ε��� �����ϴ�
            if(progress >= 0.9f)
            {
                progressUI.fillAmount = 1f;
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}

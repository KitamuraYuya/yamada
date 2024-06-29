
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class SceneLoader : MonoBehaviour //SceneLoaderという名前にします
{
    public void Start_button(string Sceneneme) //string_buttonという名前にします
    {
        SceneManager.LoadScene(Sceneneme);//secondを呼び出します
    }
}

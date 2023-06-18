using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] private IntEventChannel _sceneEventChannel;

    #region SETUP

    void OnEnable()
    {
        _sceneEventChannel.OnIntEventRaised += Load;
        SceneManager.sceneLoaded += (scene, _) =>
        {
            if (scene.buildIndex > 0) SceneManager.SetActiveScene(scene);
        };
    }

    void OnDisable()
    {
        _sceneEventChannel.OnIntEventRaised -= Load;
    }

    void Awake()
    {
        if (SceneManager.sceneCount > 1) return;
        
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    #endregion

    void Load(int index)
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
    }
}

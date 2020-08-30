using UnityEngine;

public class som : MonoBehaviour {
    private static som instance;
    void Awake () {
        if (instance != null) {
            Destroy (gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad (transform.gameObject);
        }

    }
}
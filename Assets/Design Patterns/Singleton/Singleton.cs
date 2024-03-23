using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    // Propiedad para acceder a la instancia.
    public static T Instance
    {
        get
        {
            // Si ya existe una instancia, la devuelve.
            if (_instance != null) return _instance;

            // Busca en la escena un objeto que tenga este componente.
            _instance = FindObjectOfType<T>();

            // Si no encuentra ninguno, crea uno nuevo.
            if (_instance == null)
            {
                GameObject singletonObject = new GameObject();
                _instance = singletonObject.AddComponent<T>();
                singletonObject.name = typeof(T).ToString() + " (Singleton)";

                // Hace que este objeto no se destruya al cargar una nueva escena.
                DontDestroyOnLoad(singletonObject);
            }

            return _instance;
        }
    }

    // Método virtual Awake que puedes sobrescribir en las clases herederas.
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
}

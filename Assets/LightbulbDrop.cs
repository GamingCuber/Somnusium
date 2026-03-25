using UnityEngine;

public class LightbulbDrop : MonoBehaviour
{
    public GameObject bulbDrop;
    public AudioSource breakSound;

    void Start()
    {
        breakSound = gameObject.GetComponent<AudioSource>();
    }

    public void dropItem()
    {
        Instantiate(bulbDrop);
        Invoke(nameof(destroyObject), 2f);
        Destroy(gameObject);
    }

    private void destroyObject()
    {
        Destroy(gameObject);
    }


}

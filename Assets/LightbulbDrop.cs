using UnityEngine;

public class LightbulbDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject bulbDrop;
    public AudioSource breakSound;

    public void dropItem()
    {
        Instantiate(bulbDrop);
        breakSound.Play(0);
        Invoke(nameof(destroyObject), 0.5f);
        Destroy(gameObject);
        
    }

    private void destroyObject()
    {
        Destroy(gameObject);
    }


}

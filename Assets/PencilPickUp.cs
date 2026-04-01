using UnityEngine;

public class PencilPickUp : MonoBehaviour
{
    private GameObject player;
    private GameObject pencil;
    public PlayerData playerData;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pencil = GameObject.FindGameObjectWithTag("Weapon");
        playerData.hasPencil = false;
        pencil.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) <= 3f && Input.GetKeyDown(KeyCode.F))
        {
            playerData.hasPencil = true;
            pencil.SetActive(true);
            Destroy(this);
        }
    }
}

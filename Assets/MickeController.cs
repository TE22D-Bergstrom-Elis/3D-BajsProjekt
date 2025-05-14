using UnityEngine;

public class MickeController : MonoBehaviour
{
    // gör så att bossen har ett hp
    [SerializeField]
    int maxHP = 20;

    int currentHP;

    // gör så att när man startar spelet så blir current hp samma som max hp
    void Start()
    {
        currentHP = maxHP;
    }

    // kollar så ifall skotten som har taggen bullet träffar collidern så tar bossen damage och förstör skottet
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(5);
            print("Damage tagen");
            Destroy(other.gameObject);
        }
    }

    // en class för att man ska kunna göra mycket skada utan att behöve skrive "currentHP--;" flera gånger
    void TakeDamage (int damage)
    {
        currentHP =- damage;
        // dödar bossen om hans hp är 0
        if (currentHP <= 0)
        {
            Die();
        }
    }

    // en class som skriver ut att micke är död om hans hp är 0. 
    // jag gjorde detta till en klass utifall jag vill lägga till att något händer när han dör.
    void Die()
    {
        print("Micke död");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

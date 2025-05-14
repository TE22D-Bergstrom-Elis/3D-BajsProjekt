using UnityEngine;

public class MickeController : MonoBehaviour
{
    // g�r s� att bossen har ett hp
    [SerializeField]
    int maxHP = 20;

    int currentHP;

    // g�r s� att n�r man startar spelet s� blir current hp samma som max hp
    void Start()
    {
        currentHP = maxHP;
    }

    // kollar s� ifall skotten som har taggen bullet tr�ffar collidern s� tar bossen damage och f�rst�r skottet
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(5);
            print("Damage tagen");
            Destroy(other.gameObject);
        }
    }

    // en class f�r att man ska kunna g�ra mycket skada utan att beh�ve skrive "currentHP--;" flera g�nger
    void TakeDamage (int damage)
    {
        currentHP =- damage;
        // d�dar bossen om hans hp �r 0
        if (currentHP <= 0)
        {
            Die();
        }
    }

    // en class som skriver ut att micke �r d�d om hans hp �r 0. 
    // jag gjorde detta till en klass utifall jag vill l�gga till att n�got h�nder n�r han d�r.
    void Die()
    {
        print("Micke d�d");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

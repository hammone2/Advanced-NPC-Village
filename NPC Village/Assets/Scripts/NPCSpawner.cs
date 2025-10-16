using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Knight;

    public void SpawnVillagers()
    {
        /*
        we dont want to specify the class to instantiate for each type of villager.
        instead we ask the factory to manufacture it for us
        */

        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Knight = m_Factory.GetNPC(NPCType.Knight);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Knight.Speak();
    }
}

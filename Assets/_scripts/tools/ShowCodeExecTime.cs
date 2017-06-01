using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCodeExecTime  {

    static private ShowCodeExecTime m_instance;

    float m_subtime;

    public ShowCodeExecTime Instance
    {
        get {

            if (m_instance == null)
                m_instance = new ShowCodeExecTime();
            
            return m_instance; 
        
            }
        
    }
    

    public ShowCodeExecTime()
    {

    
    }

    public void Begin()
    {
        m_subtime = Time.realtimeSinceStartup;
    }

    public void End()
    {
        m_subtime = Time.realtimeSinceStartup - m_subtime;
        Debug.Log("ShowCodeExecTime:" + m_subtime);
    }


	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CortexAccess;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft.Json.Linq;
using System;

public class Emotiv : MonoBehaviour
{

    /*
[
    "AF3/theta","AF3/alpha","AF3/betaL","AF3/betaH","AF3/gamma",
    "F7/theta","F7/alpha","F7/betaL","F7/betaH","F7/gamma",
    "F3/theta","F3/alpha","F3/betaL","F3/betaH","F3/gamma",
    "FC5/theta","FC5/alpha","FC5/betaL","FC5/betaH","FC5/gamma",
    "T7/theta","T7/alpha","T7/betaL","T7/betaH","T7/gamma",
    "P7/theta","P7/alpha","P7/betaL","P7/betaH","P7/gamma",
    "O1/theta","O1/alpha","O1/betaL","O1/betaH","O1/gamma",
    "O2/theta","O2/alpha","O2/betaL","O2/betaH","O2/gamma",
    "P8/theta","P8/alpha","P8/betaL","P8/betaH","P8/gamma",
    "T8/theta","T8/alpha","T8/betaL","T8/betaH","T8/gamma",
    "FC6/theta","FC6/alpha","FC6/betaL","FC6/betaH","FC6/gamma",
    "F4/theta","F4/alpha","F4/betaL","F4/betaH","F4/gamma",
    "F8/theta","F8/alpha","F8/betaL","F8/betaH","F8/gamma",
    "AF4/theta","AF4/alpha","AF4/betaL","AF4/betaH","AF4/gamma"
]*/

    [Header("Band Powers")]
    public float AF3Theta;
    public float AF3Alpha;
    public float AF3BetaL;
    public float AF3BetaH;
    public float AF3Gamma;
    public float F7Theta;
    public float F7Alpha;
    public float F7BetaL;
    public float F7BetaH;
    public float F7Gamma;
    public float F3Theta;
    public float F3Alpha;
    public float F3BetaL;
    public float F3BetaH;
    public float F3Gamma;
    public float FC5Theta;
    public float FC5Alpha;
    public float FC5BetaL;
    public float FC5BetaH;
    public float FC5Gamma;
    public float T7Theta;
    public float T7Alpha;
    public float T7BetaL;
    public float T7BetaH;
    public float T7Gamma;
    public float P7Theta;
    public float P7Alpha;
    public float P7BetaL;
    public float P7BetaH;
    public float P7Gamma;
    public float O1Theta;
    public float O1Alpha;
    public float O1BetaL;
    public float O1BetaH;
    public float O1Gamma;
    public float O2Theta;
    public float O2Alpha;
    public float O2BetaL;
    public float O2BetaH;
    public float O2Gamma;
    public float P8Theta;
    public float P8Alpha;
    public float P8BetaL;
    public float P8BetaH;
    public float P8Gamma;
    public float T8Theta;
    public float T8Alpha;
    public float T8BetaL;
    public float T8BetaH;
    public float T8Gamma;
    public float FC6Theta;
    public float FC6Alpha;
    public float FC6BetaL;
    public float FC6BetaH;
    public float FC6Gamma;
    public float F4Theta;
    public float F4Alpha;
    public float F4BetaL;
    public float F4BetaH;
    public float F4Gamma;
    public float F8Theta;
    public float F8Alpha;
    public float F8BetaL;
    public float F8BetaH;
    public float F8Gamma;
    public float AF4Theta;
    public float AF4Alpha;
    public float AF4BetaL;
    public float AF4BetaH;
    public float AF4Gamma;
    public float bandPowerTimestamp;

    [Header("Performance Metrics")]
    public bool engagementIsActive;
    public bool excitementIsActive;
    public bool stressIsActive;
    public bool relaxationIsActive;
    public bool interestIsActive;
    public bool focusIsActive;
    public float engagement;
    public float excitement;
    public float longTermExcitement;
    public float stress;
    public float relaxation;
    public float interest;
    public float focus;
    public float performanceMetricTimestamp;

    // Start is called before the first frame update
    void Start()
    {
        DataStreamExample dse = new DataStreamExample();
        dse.AddStreams("met");
        dse.AddStreams("pow");
        dse.OnSubscribed += SubscribedOK;
        dse.OnPerfDataReceived += OnPerfDataReceived;
        dse.OnBandPowerDataReceived += OnBandPowerDataReceived;
        dse.Start("");
    }

    private void OnBandPowerDataReceived(object sender, ArrayList e)
    {
        bandPowerTimestamp = Convert.ToSingle(e[0]);
        AF3Theta = Convert.ToSingle(e[1]);
        AF3Alpha = Convert.ToSingle(e[2]);
        AF3BetaL = Convert.ToSingle(e[3]);
        AF3BetaH = Convert.ToSingle(e[4]);
        AF3Gamma = Convert.ToSingle(e[5]);
        F7Theta = Convert.ToSingle(e[6]);
        F7Alpha = Convert.ToSingle(e[7]);
        F7BetaL = Convert.ToSingle(e[8]);
        F7BetaH = Convert.ToSingle(e[9]);
        F7Gamma = Convert.ToSingle(e[10]);
        F3Theta = Convert.ToSingle(e[11]);
        F3Alpha = Convert.ToSingle(e[12]);
        F3BetaL = Convert.ToSingle(e[13]);
        F3BetaH = Convert.ToSingle(e[14]);
        F3Gamma = Convert.ToSingle(e[15]);
        FC5Theta = Convert.ToSingle(e[16]);
        FC5Alpha = Convert.ToSingle(e[17]);
        FC5BetaL = Convert.ToSingle(e[18]);
        FC5BetaH = Convert.ToSingle(e[19]);
        FC5Gamma = Convert.ToSingle(e[20]);
        T7Theta = Convert.ToSingle(e[21]);
        T7Alpha = Convert.ToSingle(e[22]);
        T7BetaL = Convert.ToSingle(e[23]);
        T7BetaH = Convert.ToSingle(e[24]);
        T7Gamma = Convert.ToSingle(e[25]);
        P7Theta = Convert.ToSingle(e[26]);
        P7Alpha = Convert.ToSingle(e[27]);
        P7BetaL = Convert.ToSingle(e[28]);
        P7BetaH = Convert.ToSingle(e[29]);
        P7Gamma = Convert.ToSingle(e[30]);
        O1Theta = Convert.ToSingle(e[31]);
        O1Alpha = Convert.ToSingle(e[32]);
        O1BetaL = Convert.ToSingle(e[33]);
        O1BetaH = Convert.ToSingle(e[34]);
        O1Gamma = Convert.ToSingle(e[35]);
        O2Theta = Convert.ToSingle(e[36]);
        O2Alpha = Convert.ToSingle(e[37]);
        O2BetaL = Convert.ToSingle(e[38]);
        O2BetaH = Convert.ToSingle(e[39]);
        O2Gamma = Convert.ToSingle(e[40]);
        P8Theta = Convert.ToSingle(e[41]);
        P8Alpha = Convert.ToSingle(e[42]);
        P8BetaL = Convert.ToSingle(e[43]);
        P8BetaH = Convert.ToSingle(e[44]);
        P8Gamma = Convert.ToSingle(e[45]);
        T8Theta = Convert.ToSingle(e[46]);
        T8Alpha = Convert.ToSingle(e[47]);
        T8BetaL = Convert.ToSingle(e[48]);
        T8BetaH = Convert.ToSingle(e[49]);
        T8Gamma = Convert.ToSingle(e[50]);
        FC6Theta = Convert.ToSingle(e[51]);
        FC6Alpha = Convert.ToSingle(e[52]);
        FC6BetaL = Convert.ToSingle(e[53]);
        FC6BetaH = Convert.ToSingle(e[54]);
        FC6Gamma = Convert.ToSingle(e[55]);
        F4Theta = Convert.ToSingle(e[56]);
        F4Alpha = Convert.ToSingle(e[57]);
        F4BetaL = Convert.ToSingle(e[58]);
        F4BetaH = Convert.ToSingle(e[59]);
        F4Gamma = Convert.ToSingle(e[60]);
        F8Theta = Convert.ToSingle(e[61]);
        F8Alpha = Convert.ToSingle(e[62]);
        F8BetaL = Convert.ToSingle(e[63]);
        F8BetaH = Convert.ToSingle(e[64]);
        F8Gamma = Convert.ToSingle(e[65]);
        AF4Theta = Convert.ToSingle(e[66]);
        AF4Alpha = Convert.ToSingle(e[67]);
        AF4BetaL = Convert.ToSingle(e[68]);
        AF4BetaH = Convert.ToSingle(e[69]);
        AF4Gamma = Convert.ToSingle(e[70]);
    }

    private void OnPerfDataReceived(object sender, ArrayList e)
    {
        performanceMetricTimestamp = Convert.ToSingle(e[0]);
        engagementIsActive = Convert.ToBoolean(e[1]);
        engagement = Convert.ToSingle(e[2]);
        excitementIsActive = Convert.ToBoolean(e[3]);
        excitement = Convert.ToSingle(e[4]);
        longTermExcitement = Convert.ToSingle(e[5]);
        stressIsActive = Convert.ToBoolean(e[6]);
        stress = Convert.ToSingle(e[7]);
        relaxationIsActive = Convert.ToBoolean(e[8]);
        relaxation = Convert.ToSingle(e[9]);
        interestIsActive = Convert.ToBoolean(e[10]);
        interest = Convert.ToSingle(e[11]);
        focusIsActive = Convert.ToBoolean(e[12]);
        focus = Convert.ToSingle(e[13]);

    }

    private void SubscribedOK(object sender, Dictionary<string, JArray> e)
    {
        
    }


    // Update is called once per frame
    void Update()
    {

    }


}
namespace SpineHelper.Device
{

    public enum DeviceLanguage
    {
        English = 0,
        Polski = 1
    }

    public enum DeviceState
    {
        NotConnected,
        ConnectionAttempt,
        Connected,
        Ready,

        Scaled,
        Tared,
        Reset,

        Tension,
        WeightTest,
        WeightTestDone,
        SpineTest,
        SpineTestDone,
        StraightnessTestDone,

        WeightCalibration,
        SpineCalibration
    }
}

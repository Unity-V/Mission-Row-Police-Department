using System;
using System.Collections.Generic;
using GTA;
using GTA.Math;
using GTA.Native;


public class MapEditorGeneratedMap : GTA.Script
{
    public MapEditorGeneratedMap()
    {
        List<int> Props = new List<int>();
        int LodDistance = 3000;            

        Func<int, Vector3, Vector3, bool, int> createProp = new Func<int, Vector3, Vector3, bool, int>(delegate(int hash, Vector3 pos, Vector3 rot, bool dynamic)
	    {
		    Model model = new Model(hash);
		    model.Request(10000);
		    Prop prop = GTA.World.CreateProp(model, pos, rot, dynamic, false);
		    prop.Position = pos;
            prop.LodDistance = LodDistance;
            if (!dynamic)
                prop.FreezePosition = true;
		    return prop.Handle;
	    });

        bool Initialized = false;


        base.Tick += delegate (object sender, EventArgs args)
        {
            if (!Initialized)
            {
                /* PROPS */
                Props.Add(createProp(680549965, new GTA.Math.Vector3(407.2722f, -1014.788f, 28.44351f), new GTA.Math.Vector3(0f, 0f, 78.99978f), false));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.84f, -1013.24f, 30.03f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.84f, -1013.24f, 29.05f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.84f, -1013.24f, 28.07f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(1286535678, new GTA.Math.Vector3(419.9778f, -1024.52f, 28.11649f), new GTA.Math.Vector3(0f, -5.008956E-06f, -89.99999f), true));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.94f, -1028.31f, 30.03f), new GTA.Math.Vector3(0f, -5.008956E-06f, -180f), false));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.94f, -1028.31f, 29.05f), new GTA.Math.Vector3(0f, -5.008956E-06f, -180f), false));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.94f, -1028.31f, 28.07f), new GTA.Math.Vector3(0f, -5.008956E-06f, -180f), false));
                Props.Add(createProp(-105439435, new GTA.Math.Vector3(417.92f, -1028.51f, 28.15224f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1830645735, new GTA.Math.Vector3(416.8101f, -1028.708f, 28.71f), new GTA.Math.Vector3(0f, 0f, 89.99963f), false));
                Props.Add(createProp(-500649904, new GTA.Math.Vector3(416.68f, -1027.9f, 29.45f), new GTA.Math.Vector3(0f, 0f, 89.99959f), false));
                Props.Add(createProp(-8033527, new GTA.Math.Vector3(416.77f, -1028.33f, 29.44f), new GTA.Math.Vector3(0f, 0f, 117.9991f), false));
                Props.Add(createProp(-2122821887, new GTA.Math.Vector3(419.72f, -1016.76f, 29.66f), new GTA.Math.Vector3(0f, 0f, -88.99956f), false));
                Props.Add(createProp(538002882, new GTA.Math.Vector3(417.2f, -1027.766f, 29.03f), new GTA.Math.Vector3(0f, 0f, -76.99979f), false));
                Props.Add(createProp(1355944948, new GTA.Math.Vector3(416.9182f, -1027.883f, 29.23f), new GTA.Math.Vector3(0f, 0f, 89.99944f), false));
                Props.Add(createProp(-286280212, new GTA.Math.Vector3(416.8491f, -1027.467f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 87.9996f), false));
                Props.Add(createProp(389765485, new GTA.Math.Vector3(416.6884f, -1026.917f, 30.93338f), new GTA.Math.Vector3(0f, 0f, 64.99983f), false));
                Props.Add(createProp(-60003998, new GTA.Math.Vector3(416.5511f, -1029.399f, 29.67176f), new GTA.Math.Vector3(0f, 0f, 89.99957f), false));
                Props.Add(createProp(-719006148, new GTA.Math.Vector3(416.6529f, -1027.167f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 139.9994f), false));
                Props.Add(createProp(-1914174611, new GTA.Math.Vector3(418.5476f, -1026.1f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-163314598, new GTA.Math.Vector3(416.9053f, -1027.226f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(921231391, new GTA.Math.Vector3(416.6495f, -1026.978f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 57.99972f), false));
                Props.Add(createProp(-925658112, new GTA.Math.Vector3(418.9269f, -1031.485f, 29.84618f), new GTA.Math.Vector3(0f, 0f, 179.9987f), false));
                Props.Add(createProp(-1503146199, new GTA.Math.Vector3(417.3746f, -1031.485f, 29.51586f), new GTA.Math.Vector3(0f, 0f, -178.999f), false));
                Props.Add(createProp(-1721110035, new GTA.Math.Vector3(416.7343f, -1029.157f, 29.20722f), new GTA.Math.Vector3(0f, 0f, -44.99983f), false));
                Props.Add(createProp(-590902397, new GTA.Math.Vector3(419.074f, -1027.281f, 28.44519f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(2107151586, new GTA.Math.Vector3(416.8403f, -1026.223f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 27.99995f), false));
                Props.Add(createProp(-1883980157, new GTA.Math.Vector3(419.0181f, -1026.203f, 29.32f), new GTA.Math.Vector3(0f, 0f, -109.9995f), false));
                Props.Add(createProp(1244929250, new GTA.Math.Vector3(417.931f, -1026.089f, 29.20722f), new GTA.Math.Vector3(0f, 0f, 5.999979f), false));
                Props.Add(createProp(270965283, new GTA.Math.Vector3(419.3437f, -1029.69f, 29.52f), new GTA.Math.Vector3(-5.97114E-13f, -5.008956E-06f, -89.99999f), false));
                Props.Add(createProp(270965283, new GTA.Math.Vector3(416.45f, -1029.69f, 29.49f), new GTA.Math.Vector3(-1.384231E-12f, -5.008955E-06f, -89.99998f), true));
                Props.Add(createProp(-133590469, new GTA.Math.Vector3(419.94f, -1032.235f, 26.79f), new GTA.Math.Vector3(-90f, 180f, 0f), false));
                Props.Add(createProp(1257426102, new GTA.Math.Vector3(418.141f, -1012.194f, 29.37f), new GTA.Math.Vector3(-5.97114E-13f, -5.008956E-06f, -89.99999f), false));
                Props.Add(createProp(493205544, new GTA.Math.Vector3(415.8104f, -1011.136f, 28.25446f), new GTA.Math.Vector3(0f, 0f, -19.99998f), false));
                Props.Add(createProp(493205544, new GTA.Math.Vector3(416.0948f, -1013.591f, 28.23706f), new GTA.Math.Vector3(0f, 0f, -19.99998f), false));
                Props.Add(createProp(987331897, new GTA.Math.Vector3(415.8452f, -1011.034f, 29.22306f), new GTA.Math.Vector3(0f, 0f, 30.99997f), false));
                Props.Add(createProp(-1321253704, new GTA.Math.Vector3(415.8237f, -1011.276f, 29.23f), new GTA.Math.Vector3(0f, 0f, -16.99999f), false));
                Props.Add(createProp(421881790, new GTA.Math.Vector3(416.0114f, -1013.531f, 29.20566f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1519122176, new GTA.Math.Vector3(416.209f, -1013.623f, 29.20566f), new GTA.Math.Vector3(0f, 0f, 16.00002f), false));
                Props.Add(createProp(-870868698, new GTA.Math.Vector3(419.3718f, -985.8433f, 28.39651f), new GTA.Math.Vector3(-5.97114E-13f, -5.008956E-06f, -89.99999f), false));
                Props.Add(createProp(16567861, new GTA.Math.Vector3(419.3645f, -986.4749f, 28.38629f), new GTA.Math.Vector3(0f, 0f, -65.99971f), false));
                Props.Add(createProp(1138881502, new GTA.Math.Vector3(419.39f, -987.69f, 28.98346f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4071f, -1004.532f, 28.40757f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(418.548f, -1016.798f, 28.16186f), new GTA.Math.Vector3(0f, 0f, 89.9995f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(417.1606f, -1016.75f, 28.20706f), new GTA.Math.Vector3(0f, 0f, 89.9995f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(415.8208f, -1016.763f, 28.25097f), new GTA.Math.Vector3(0f, 0f, 89.99948f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(414.502f, -1016.774f, 28.29036f), new GTA.Math.Vector3(0f, 0f, 89.99944f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(413.1731f, -1016.762f, 28.32946f), new GTA.Math.Vector3(0f, 0f, 89.9994f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.8394f, -1016.779f, 28.35376f), new GTA.Math.Vector3(0f, 0f, 89.99935f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(410.4274f, -1016.776f, 28.35134f), new GTA.Math.Vector3(0f, 0f, 89.9993f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(408.8414f, -1016.761f, 28.36695f), new GTA.Math.Vector3(0f, 0f, 89.99924f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(407.2951f, -1016.776f, 28.38203f), new GTA.Math.Vector3(0f, 0f, 89.99917f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(405.8261f, -1016.808f, 28.3945f), new GTA.Math.Vector3(0f, 0f, 88.99747f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(405.1146f, -1015.572f, 28.41148f), new GTA.Math.Vector3(0f, 0f, -2.002795f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(405.1438f, -1014.158f, 28.41594f), new GTA.Math.Vector3(0f, 0f, -2.002795f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(405.2693f, -1012.652f, 28.41034f), new GTA.Math.Vector3(0f, 0f, -22.00278f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.4071f, -1011.531f, 28.40936f), new GTA.Math.Vector3(0f, 0f, -50.00272f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(407.7861f, -1010.511f, 28.40946f), new GTA.Math.Vector3(0f, 0f, -50.00272f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(408.9819f, -1009.641f, 28.40907f), new GTA.Math.Vector3(0f, 0f, -52.00269f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(410.158f, -1008.779f, 28.40972f), new GTA.Math.Vector3(0f, 0f, -52.00263f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.2346f, -1007.537f, 28.39775f), new GTA.Math.Vector3(0f, 0f, -22.00252f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4131f, -1006.062f, 28.40704f), new GTA.Math.Vector3(0f, 0f, -1.002508f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4095f, -1003.162f, 28.40851f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4071f, -1001.768f, 28.40956f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.427f, -1000.459f, 28.41007f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4189f, -999.0312f, 28.41128f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4177f, -997.5291f, 28.41088f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4097f, -995.983f, 28.41111f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4169f, -994.5809f, 28.4115f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4324f, -993.1949f, 28.41232f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4182f, -991.8024f, 28.41191f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4141f, -990.4072f, 28.41142f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4125f, -988.9726f, 28.4143f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.3997f, -987.5898f, 28.4141f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.41f, -986.2145f, 28.41393f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4133f, -984.8569f, 28.41375f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4153f, -983.4342f, 28.41492f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4242f, -982.0328f, 28.41585f), new GTA.Math.Vector3(0f, 0f, 0f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.4127f, -980.5696f, 28.41667f), new GTA.Math.Vector3(0f, 0f, 3f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.0166f, -979.1788f, 28.41716f), new GTA.Math.Vector3(0f, 0f, 32.99993f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(410.0816f, -978.189f, 28.41767f), new GTA.Math.Vector3(0f, 0f, 50.99985f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(408.995f, -977.2657f, 28.41766f), new GTA.Math.Vector3(0f, 0f, 50.99986f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(408.0663f, -976.4722f, 28.41662f), new GTA.Math.Vector3(0f, 0f, 50.99986f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(407.0578f, -975.6158f, 28.41436f), new GTA.Math.Vector3(0f, 0f, 48.99982f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.3839f, -974.2438f, 28.41438f), new GTA.Math.Vector3(0f, 0f, 2.999748f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.3832f, -972.6814f, 28.41692f), new GTA.Math.Vector3(0f, 0f, 0.9997475f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.4043f, -971.092f, 28.42093f), new GTA.Math.Vector3(0f, 0f, 0.9997475f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.4341f, -969.6724f, 28.43101f), new GTA.Math.Vector3(0f, 0f, 0.9997475f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(406.6156f, -967.0779f, 28.45885f), new GTA.Math.Vector3(0f, 0f, -8.000241f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(407.0772f, -965.5823f, 28.41971f), new GTA.Math.Vector3(0f, 0f, -25.00017f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(407.7665f, -964.3682f, 28.45524f), new GTA.Math.Vector3(0f, 0f, -30.00002f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(408.8392f, -963.1469f, 28.50093f), new GTA.Math.Vector3(0f, 0f, -41.99998f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(410.0526f, -962.2737f, 28.48125f), new GTA.Math.Vector3(0f, 0f, -58.99992f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(411.5882f, -961.4947f, 28.46307f), new GTA.Math.Vector3(0f, 0f, -75.99979f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(413.2167f, -961.1476f, 28.49995f), new GTA.Math.Vector3(0f, 0f, -82.99974f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(414.6338f, -961.0022f, 28.47279f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(415.7465f, -961.0067f, 28.45584f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(417.1548f, -960.9976f, 28.43776f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(418.5628f, -960.9938f, 28.41969f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(419.9482f, -960.9945f, 28.40192f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(421.3193f, -960.9807f, 28.38432f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(422.5435f, -961.0028f, 28.36863f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(423.9409f, -961.0081f, 28.35071f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(425.2859f, -961.01f, 28.33346f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(426.6925f, -961.009f, 28.31541f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(428.1038f, -961.0236f, 28.25942f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(429.7803f, -961.0256f, 28.25119f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(431.3719f, -961.0179f, 28.23811f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(432.8886f, -961.0255f, 28.20754f), new GTA.Math.Vector3(0f, 0f, -90.99963f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(434.7386f, -961.0587f, 28.16195f), new GTA.Math.Vector3(0f, 0f, -141.9993f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(434.8607f, -962.6874f, 28.16403f), new GTA.Math.Vector3(0f, 0f, 178.0011f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(434.8678f, -964.134f, 28.16865f), new GTA.Math.Vector3(0f, 0f, 178.0011f), false));
                Props.Add(createProp(-1510803822, new GTA.Math.Vector3(434.8247f, -966.202f, 28.17793f), new GTA.Math.Vector3(0f, 0f, 178.0011f), false));
                Props.Add(createProp(-509973344, new GTA.Math.Vector3(416.8636f, -1031.485f, 30.45775f), new GTA.Math.Vector3(0f, -5.008956E-06f, -180f), false));
                Props.Add(createProp(1805980844, new GTA.Math.Vector3(436.71f, -973.3517f, 29.71507f), new GTA.Math.Vector3(0f, 0f, -89.99964f), false));
                Props.Add(createProp(1805980844, new GTA.Math.Vector3(436.7139f, -975.7861f, 29.72045f), new GTA.Math.Vector3(0f, 0f, -89.99963f), false));
                Props.Add(createProp(-512634970, new GTA.Math.Vector3(466.51f, -1021.205f, 28.55f), new GTA.Math.Vector3(5.97114E-13f, -5.008956E-06f, 89.99999f), false));
                Props.Add(createProp(1339433404, new GTA.Math.Vector3(450.0168f, -995.3684f, 24.78699f), new GTA.Math.Vector3(0f, 0f, 89.99952f), false));
                Props.Add(createProp(1339433404, new GTA.Math.Vector3(433.8657f, -995.5845f, 24.78474f), new GTA.Math.Vector3(0f, 0f, 89.99951f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(475.411f, -979.1661f, 28.3869f), new GTA.Math.Vector3(0f, 0f, 88.99968f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(455.9742f, -971.9109f, 31.0388f), new GTA.Math.Vector3(0f, 0f, 88.99968f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(434.4586f, -984.8932f, 31.3267f), new GTA.Math.Vector3(0f, 0f, 178.9989f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(444.1377f, -999.0228f, 31.18863f), new GTA.Math.Vector3(0f, 0f, -3.85642E-05f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(470.1515f, -1014.749f, 26.82603f), new GTA.Math.Vector3(0f, 0f, -3.85642E-05f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(464.7271f, -1011.642f, 33.42945f), new GTA.Math.Vector3(0f, 0f, -3.85642E-05f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(459.3837f, -1008.811f, 28.78154f), new GTA.Math.Vector3(0f, 0f, -87.99963f), false));
                Props.Add(createProp(2118221788, new GTA.Math.Vector3(488.3694f, -1001.198f, 28.17954f), new GTA.Math.Vector3(0f, 0f, 5.000617f), false));


                /* VEHICLES */


                /* PEDS */


                /* PICKUPS */

                Initialized = true;
            }

            /* MARKERS */


            /* WORLD */
            Prop returnedProp;
            returnedProp = Function.Call<Prop>(Hash.GET_CLOSEST_OBJECT_OF_TYPE, 307.952f, -619.6721f, 42.47605f, 1f, 765541575, 0);
            if (returnedProp != null && returnedProp.Handle != 0 && !Props.Contains(returnedProp.Handle))
                returnedProp.Delete();

        };
    }
}
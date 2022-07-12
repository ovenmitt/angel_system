//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Angel
{
    [Serializable]
    public class QueryTaskGraphRequest : Message
    {
        public const string k_RosMessageName = "angel_msgs/QueryTaskGraph";
        public override string RosMessageName => k_RosMessageName;

        //  Get the full task graph for the current task.
        public byte test;

        public QueryTaskGraphRequest()
        {
            this.test = 0;
        }

        public QueryTaskGraphRequest(byte test)
        {
            this.test = test;
        }

        public static QueryTaskGraphRequest Deserialize(MessageDeserializer deserializer) => new QueryTaskGraphRequest(deserializer);

        private QueryTaskGraphRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.test);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.test);
        }

        public override string ToString()
        {
            return "QueryTaskGraphRequest: " +
            "\ntest: " + test.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
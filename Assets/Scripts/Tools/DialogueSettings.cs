using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;


namespace Game.Tools
{
    [XmlRoot("dialogue")]
    public class DialogueSettings
    {
        [XmlElement("node")] public Node[] Nodes;

        public static DialogueSettings Load(TextAsset xml){
            XmlSerializer serializer = new XmlSerializer(typeof(DialogueSettings));
            StringReader reader = new StringReader(xml.text);
            DialogueSettings settings = serializer.Deserialize(reader) as DialogueSettings;
            return settings;
        }
    }

    [System.Serializable]
    public class Node
    {
        [XmlElement("text")] public string text;
    }
}



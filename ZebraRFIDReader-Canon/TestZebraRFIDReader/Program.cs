using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Symbol.RFID3;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
// including the M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace TestZebraRFIDReader
{
    public class BackendData 
    {
        public List<string> rfids { get; set; }
    }
    class Program
    {
        static MqttClient client;
        static string clientId;
        static RFIDReader rfid3;
        static Dictionary<string, string> listId;
        static string MQTT_BROKER = "127.0.0.1";

        static string RFID_HOST = "169.254.219.214";
        static uint RFID_PORT = 5084;

        //get data from reader and store in a list
        static List<string> read_rf_id(Int32 time)
        {
            var check = rfid3.IsConnected;
            /* If connnected print True */
            Console.WriteLine(check);
            rfid3.Config.ResetFactoryDefaults();

            Console.WriteLine("Start Reading");
            rfid3.Actions.Inventory.Perform();

            // stop the inventory
            Thread.Sleep(time);
            Symbol.RFID3.TagData[] tagData = rfid3.Actions.GetReadTags(1000000);
            List<string> listTag = new List<string>();
            int tagCount = 0;

            if (tagData != null)
            {
                tagCount = tagData.Length;
                for (int nIndex = 0; nIndex < tagData.Length; nIndex++)
                {
                    if (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_NONE ||
                        (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ &&
                        tagData[nIndex].OpStatus == ACCESS_OPERATION_STATUS.ACCESS_SUCCESS))
                    {
                        Symbol.RFID3.TagData tag = tagData[nIndex];
                        string tagID = tag.TagID;
                        //Console.WriteLine(tagID);
                        if (!listTag.Contains(tagID))
                        {
                            listTag.Add(tagID);
                        }
                    }
                }
                
                Console.WriteLine("Readed => {0}", listTag.Count);
            } else
            {
                Console.WriteLine("---->> None Tag Read");
            }
            rfid3.Actions.Inventory.Stop();
            Console.WriteLine("Finish Reading \n----------------------------------------------\n");
            return listTag;

        }

        static void init_mqtt()
        {
            try
            {
                //  initialize mqtt data
                client = new MqttClient(MQTT_BROKER);
                // register a callback-function (we have to implement, see below) which is called by the library when a message was received
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                // use a unique id as client id, each time we start the application
                clientId = Guid.NewGuid().ToString();

                client.Connect(clientId);

                string Topic = "/rfid_cmd";
                client.Subscribe(new string[] { Topic }, new byte[] { 0 });
                Console.WriteLine("Connected to MQTT Broker");
            } catch
            {
                Console.WriteLine("Error connect to MQTT Broker");
            }
            
        }
        //connect to reader
        static void init_rfid_reader()
        {
            try
            {
                rfid3 = new RFIDReader(RFID_HOST, RFID_PORT, 0);
                rfid3.Connect();
                Console.WriteLine("Connected to RFID Reader");
            } catch
            {
                Console.WriteLine("ERROR connect to RFID Reader");
            }  
        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            var time = Convert.ToInt32(ReceivedMessage);
            Console.WriteLine("Set read timeout to ", time , " (ms)");
            var listTag = read_rf_id(time);
            //Console.Write(listTag);

            //List<string> listTag = new List<string>();
            //listTag.Add("A0001");
            //listTag.Add("A0002");
            //listTag.Add("A0003");
            //listTag.Add("A0004");

            // remaping data
            List<string> sendingTag = new List<string>();
            foreach (string tag in listTag)
            {
                sendingTag.Add(tag);
            };
            var rfIdData = JsonConvert.SerializeObject(sendingTag);
            // send data to frontend
            client.Publish("/rfid_canon", Encoding.UTF8.GetBytes(rfIdData), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            Console.WriteLine(rfIdData);
            Console.WriteLine("Read done");
        }
 
        static void load_rfid()
        {
            listId = new Dictionary<string, string>();
            listId["A0001"] = "point_0_0";
            listId["A0002"] = "point_0_1";
            listId["A0003"] = "point_0_2";
            listId["A0004"] = "point_0_3";
        }
        static void Main(string[] args)
        {
            load_rfid();
            init_rfid_reader();
            init_mqtt();
            
        }
    }
}

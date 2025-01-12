/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class SetCameraInfoResponse : Message
    {
        [Newtonsoft.Json.JsonIgnore]
        public const string RosMessageName = "sensor_msgs/SetCameraInfo";

        public bool success;
        //  True if the call succeeded
        public string status_message;
        //  Used to give details about success

        public SetCameraInfoResponse()
        {
            this.success = false;
            this.status_message = "";
        }

        public SetCameraInfoResponse(bool success, string status_message)
        {
            this.success = success;
            this.status_message = status_message;
        }
    }
}

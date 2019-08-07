/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Sensor;

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class SetCameraInfoRequest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/SetCameraInfo";

        //  This service requests that a camera stores the given CameraInfo 
        //  as that camera's calibration information.
        // 
        //  The width and height in the camera_info field should match what the
        //  camera is currently outputting on its camera_info topic, and the camera
        //  will assume that the region of the imager that is being referred to is
        //  the region that the camera is currently capturing.
        public CameraInfo camera_info;
        //  The camera_info to store

        public SetCameraInfoRequest()
        {
            this.camera_info = new CameraInfo();
        }

        public SetCameraInfoRequest(CameraInfo camera_info)
        {
            this.camera_info = camera_info;
        }
    }
}
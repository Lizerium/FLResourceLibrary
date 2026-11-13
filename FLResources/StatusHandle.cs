/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2026 06:51:30
 * Version: 1.0.448
 */

namespace FLResources
{
    public enum ErrorCode
    {
        Ok = 200,
        Error = 300,
        Exception = 404
    }

    public class StatusHandle
    {
        public object Data;
        public ErrorCode Code;
        public string Message;
    }
}

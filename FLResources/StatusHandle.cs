/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 мая 2026 14:54:54
 * Version: 1.0.282
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

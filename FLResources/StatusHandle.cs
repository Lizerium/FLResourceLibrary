/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 сентября 2026 08:13:30
 * Version: 1.0.393
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

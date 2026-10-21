/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2026 10:05:15
 * Version: 1.0.425
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

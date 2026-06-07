/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июня 2026 18:21:14
 * Version: 1.0.289
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

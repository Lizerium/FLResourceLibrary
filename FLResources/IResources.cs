/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:03:38
 * Version: 1.0.271
 */


using System.Collections.Generic;

namespace FLResources
{
    public interface IResources
    {
        Dictionary<string, int> LoadIds(int ids);
        StatusHandle GetData(string nameResources, int id);
    }
}

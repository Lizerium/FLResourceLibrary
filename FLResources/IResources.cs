/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 сентября 2026 06:54:36
 * Version: 1.0.377
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

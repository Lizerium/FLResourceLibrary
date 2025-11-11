/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:53:53
 * Version: 1.0.78
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

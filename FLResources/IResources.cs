/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:30:55
 * Version: 1.0.122
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

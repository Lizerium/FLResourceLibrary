/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2026 06:52:04
 * Version: 1.0.373
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

/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июня 2026 11:42:27
 * Version: 1.0.310
 */

using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace FLCore
{
    public class DataSetter
    {
        public ResourceManager GetResource(string key, List<string> keys, string nameSpace, Assembly assembly)
        {
            foreach (string item in keys)
            {
                var name = item.Substring(0, item.IndexOf("."));
                if (name == key)
                {
                    var nameResources = item.Substring(0, item.IndexOf("."));
                    var baseName = nameSpace + ".Properties." + nameResources;
                    return new ResourceManager(baseName, assembly);
                }
            }
            return null;
        }
    }
}

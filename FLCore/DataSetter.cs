/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июня 2026 18:21:14
 * Version: 1.0.289
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

/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:34
 * Version: 1.0.243
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

/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:43:01
 * Version: 1.0.186
 */

namespace FLCore
{
    public static class Extensions
    {
        public static string ReplaceNegativeSymphols(this string val, string sym)
        {
            var index1 = val.IndexOf(sym);
            var index2 = val.LastIndexOf(sym);
            if (index1 != -1 && index2 != -1 && index1 < index2)
            {
                var f1 = val.Substring(0, index1);
                var f2 = val.Substring(index1 + sym.Length, index2 - (index1 + sym.Length));
                var f3 = val.Substring(index2 + sym.Length);
                val = f1 + "«" + f2 + "»" + f3;
            }
            return val;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WpfCAcademy.Model.BridgeDeck;

namespace WpfCAcademy.Factory
{
    public static class BridgeFirstBid
    {
        public enum Conventions : int {Natural, StrongPass};
        public static string PredictFirstBid(BridgeHand Hand, Conventions Convention)
        {
            string FactoryClassName = Enum.GetName(typeof(Conventions), Convention)+"FirstBid";
            MethodInfo method = Type.GetType(FactoryClassName).GetType().GetMethod("PredictFirstBid");
            object result = method.Invoke(Hand, null);
            return result.ToString();
        }
    }
}

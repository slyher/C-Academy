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
        public enum Conventions : int { Natural, StrongPass };
        /*
         * https://stackoverflow.com/questions/801070/dynamically-invoking-any-function-by-passing-function-name-as-string
         */
        public static string PredictFirstBid(BridgeHand Hand, Conventions Convention)
        {
            object[] methodArgs = new object[1];
            methodArgs[0] = Hand;
            object[] constructorArgs = new object[0];
            string FactoryClassName = "WpfCAcademy.Factory." + Enum.GetName(typeof(Conventions), Convention) + "FirstBid";
            var type = Type.GetType(FactoryClassName);
            object instance = Activator.CreateInstance(type, constructorArgs);
            MethodInfo method = type.GetMethod("PredictFirstBid");
            object result = method.Invoke(instance, methodArgs);
            return result.ToString();
        }
    }
}

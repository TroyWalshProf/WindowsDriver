using System.Windows.Automation;
using WindowsDriver.Requests;

namespace WindowsDriver.AutomationFramework
{
    public static class Utilities
    {
        public static AutomationElement GetApplicationRoot(string sessionId)
        {
            var id = sessionId.Split('-').Last().TrimStart('0');
            return AutomationElement.FromHandle(new IntPtr(Convert.ToInt64(id)));
        }


        public static string FindElementShortcut(Find find, string sessionId)
        {
            AutomationElement element = FindElement(find,sessionId);
            int nativeHandle = element.Current.NativeWindowHandle;
            var runtime  = element.GetRuntimeId();

            bool complexElementFind = false;
            
            if (nativeHandle == 0)
            {
                TreeWalker walker = TreeWalker.ControlViewWalker;

                complexElementFind = true;
                
                while (nativeHandle == 0)
                {
                    element = walker.GetParent(element);
                    nativeHandle = element.Current.NativeWindowHandle;
                }
            }

            if (complexElementFind)
            {
                var runtimeString = string.Join('.', runtime);
                return $"{nativeHandle}_{runtimeString}";
            }

            return nativeHandle.ToString();
        }


        public static AutomationElement FindElement(Find find, string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);

            PropertyCondition con = Condition(find);
            return app.FindFirst(TreeScope.Subtree, con);
        }

        public static AutomationElementCollection FindElements(Find find, string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);

            PropertyCondition con = Condition(find);
            return app.FindAll(TreeScope.Subtree, con);
        }


        public static AutomationElement GetElement(string NavtiveSelector)
        {
            var splitHandle= NavtiveSelector.Split('_');
            var element = AutomationElement.FromHandle(new IntPtr(Convert.ToInt64(splitHandle[0])));

            if (splitHandle.Length > 1)
            {
                var runtime = splitHandle[1].Split('.').Select(Int32.Parse).ToArray<Int32>();
                return element.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.RuntimeIdProperty, runtime));
            }

            return element;
        }


        private static PropertyCondition Condition(Find find)
        {
            switch (find._using.ToLower())
            {
                case "id":
                    return new PropertyCondition(AutomationElement.AutomationIdProperty, find.value);
                case "name":
                    return new PropertyCondition(AutomationElement.NameProperty, find.value);
                case "class name":
                    return new PropertyCondition(AutomationElement.ClassNameProperty, find.value);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

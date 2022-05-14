using System.Windows.Automation;
using System.Xml;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using WindowsDriver.Requests;

namespace WindowsDriver.AutomationFramework
{
    public static class Utilities
    {
        public static AutomationElement GetApplicationRoot(string sessionId)
        {
            return AutomationElement.FromHandle(GetHandle(sessionId));
        }

        public static IntPtr GetHandle(string sessionId)
        {
            var id = sessionId.Split('-').Last().TrimStart('0');
            return new IntPtr(Convert.ToInt64(id));
        }


        public static string FindElementShortcut(FindJson find, string sessionId)
        {
            AutomationElement element = FindElement(find, sessionId);
            int nativeHandle = element.Current.NativeWindowHandle;
            var runtime = element.GetRuntimeId();

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


        public static AutomationElement? FindElementByXPath(AutomationElement rootElement, string xpath)
        {
            // var document = SudoHtml.GetHtmlDocument(rootElement);
            // var node = document.DocumentNode.SelectSingleNode(xpath);


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(SudoHtml.GetPageSource(rootElement));

            XmlNode? root = doc.DocumentElement;

            // Select all nodes where the book price is greater than 10.00.  
            XmlNode? node = root?.SelectSingleNode(xpath);



            if (node == null)
            {
                return null;
            }

            return GetElement(rootElement, node.Attributes["RuntimeId"].Value);
        }

        public static AutomationElement? FindElementByCss(AutomationElement rootElement, string css)
        {
            var document = ToHtmlDocument(SudoHtml.GetPageSource(rootElement));
            var element = document.QuerySelector(css);

            if (element == null)
            {
                return null;
            }

            return GetElement(rootElement, element.Attributes["runtimeid"].Value);
        }

        public static AutomationElement FindElement(FindJson find, string sessionId)
        {
            var app = GetApplicationRoot(sessionId);
            return FindElement(app, find);
        }

        public static AutomationElementCollection FindElements(FindJson find, string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);
            return FindElements(app, find);
        }

        public static AutomationElement FindElement(AutomationElement root, FindJson find)
        {
            switch (find._using.ToLower())
            {
                case "id":
                case "name":
                case "class name":
                    return root.FindFirst(TreeScope.Subtree, Condition(find));
                case "xpath":
                    return FindElementByXPath(root, find.value);
                case "css selector":
                    return FindElementByCss(root, find.value);
                default:
                    throw new NotImplementedException($"'{find._using}' selector is not supported.");
            }
        }



        public static IDocument ToHtmlDocument(this String sourceCode)
        {
            var context = BrowsingContext.New(Configuration.Default);
            var htmlParser = context.GetService<IHtmlParser>();
            return htmlParser.ParseDocument(sourceCode);
        }


        public static AutomationElementCollection FindElements(AutomationElement root, FindJson find)
        {
            switch (find._using.ToLower())
            {
                case "id":
                case "name":
                case "class name":
                    return root.FindAll(TreeScope.Subtree, Condition(find));
                case "xpath":

                default:
                    throw new NotImplementedException($"'{find._using}' selector is not supported.");
            }
        }


        public static AutomationElement GetElement(string NavtiveSelector)
        {
            var splitHandle = NavtiveSelector.Split('_');
            var element = AutomationElement.FromHandle(new IntPtr(Convert.ToInt64(splitHandle[0])));

            if (splitHandle.Length > 1)
            {
                return GetElement(element, splitHandle[1]);
            }

            return element;
        }
        public static AutomationElement GetElement(AutomationElement rootElement, string runtimeId)
        {
            var runtime = runtimeId.Split('.').Select(Int32.Parse).ToArray();
            return rootElement.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.RuntimeIdProperty, runtime));
        }


        private static PropertyCondition Condition(FindJson find)
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

        public static void Resize(AutomationElement applicationRoot, WindowVisualState state)
        {
            var pattern = applicationRoot.GetCurrentPattern(WindowPattern.Pattern) as WindowPattern;
            pattern?.SetWindowVisualState(state);
        }
    }
}
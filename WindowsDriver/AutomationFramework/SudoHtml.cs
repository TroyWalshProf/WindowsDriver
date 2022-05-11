using HtmlAgilityPack;
using System.Text;
using System.Windows.Automation;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WindowsDriver.AutomationFramework
{
    public class SudoHtml
    {

        public static string GetPageSource(AutomationElement rootElement)
        {
            var document = GetHtmlDocument(rootElement);
            return document.DocumentNode.OuterHtml;
        }

        public static HtmlDocument GetHtmlDocument(AutomationElement rootElement)
        {
            var document = new HtmlDocument();

            document.CreateComment("<?xml version=\"1.0\" encoding=\"utf - 16\"?>");

            Populate(document, rootElement, document.DocumentNode);
            document.OptionOutputOriginalCase = true;
            return document;
        }

        public static void Populate(HtmlDocument parentDoc, AutomationElement rootElement, HtmlNode parentNode)
        {
            HtmlNode node = PopulateNode(parentDoc, rootElement);
            parentNode.AppendChild(node);

            foreach (AutomationElement child in rootElement.FindAll(TreeScope.Children, Condition.TrueCondition))
            {
                Populate(parentDoc, child, node);
            }
        }

        public static HtmlNode PopulateNode(HtmlDocument parentDoc, AutomationElement element)
        {
            var current = element.Current;
            var node = parentDoc.CreateElement(ToPascal(current.LocalizedControlType));
            node.SetAttributeValue(ToPascal(nameof(current.AcceleratorKey)), current.AcceleratorKey);
            node.SetAttributeValue(ToPascal(nameof(current.AccessKey)), current.AccessKey);
            node.SetAttributeValue(ToPascal(nameof(current.AutomationId)), current.AutomationId);
            node.SetAttributeValue(ToPascal(nameof(current.ClassName)), current.ClassName);
            node.SetAttributeValue(ToPascal(nameof(current.FrameworkId)), current.FrameworkId);
            node.SetAttributeValue(ToPascal(nameof(current.HasKeyboardFocus)), current.HasKeyboardFocus.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.HelpText)), current.HelpText);
            node.SetAttributeValue(ToPascal(nameof(current.IsContentElement)), current.IsContentElement.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsControlElement)), current.IsControlElement.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsEnabled)), current.IsEnabled.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsKeyboardFocusable)), current.IsKeyboardFocusable.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsOffscreen)), current.IsOffscreen.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsPassword)), current.IsPassword.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.IsRequiredForForm)), current.IsRequiredForForm.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.ItemStatus)), current.ItemStatus);
            node.SetAttributeValue(ToPascal(nameof(current.ItemType)), current.ItemType);
            node.SetAttributeValue(ToPascal(nameof(current.LocalizedControlType)), current.LocalizedControlType);
            node.SetAttributeValue(ToPascal(nameof(current.Name)), current.Name);
            node.SetAttributeValue(ToPascal(nameof(current.Orientation)), current.Orientation.ToString());
            node.SetAttributeValue(ToPascal(nameof(current.ProcessId)), current.ProcessId.ToString());
            node.SetAttributeValue("RuntimeId", string.Join('.', element.GetRuntimeId()));

            var rectangle = current.BoundingRectangle;
            node.SetAttributeValue("X", rectangle.X.ToString());
            node.SetAttributeValue("Y", rectangle.Y.ToString());
            node.SetAttributeValue("Width", rectangle.Width.ToString());
            node.SetAttributeValue("Height", rectangle.Height.ToString());

            return node;
            //////// TODO ADD
            /// CanMaximize="True" CanMinimize="True" IsModal="False" WindowVisualState="Normal" WindowInteractionState="ReadyForUserInteraction" IsTopmost="False" CanRotate="False" CanResize="True" CanMove="True" IsAvailable="True"
        }

        private static string ToPascal(string value)
        {
            StringBuilder formattedString = new(); 

            foreach(var sub in value.Split(' '))
            {
                formattedString.Append(char.ToUpper(sub[0]) + sub.Substring(1));
            }

            return formattedString.ToString();
        }
    }
}

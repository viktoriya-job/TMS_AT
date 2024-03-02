using OpenQA.Selenium;

namespace Wrappers.Elements.HerokuappTable
{
    public class HTable
    {
        private UIElement _uiElement;
        private List<string> _columns;
        private List<HTableRow> _rows;

        public HTable(IWebDriver webDriver, By by)
        {
            _uiElement = new UIElement(webDriver, by);
            _columns = new List<string>();
            _rows = new List<HTableRow>();

            foreach (var columnElement in _uiElement.FindUIElements(By.CssSelector("th>span")))
            {
                _columns.Add(columnElement.Text.Trim());
            }

            foreach (var rowElement in _uiElement.FindUIElements(By.CssSelector("tbody>tr")))
            {
                _rows.Add(new HTableRow(rowElement));
            }
        }

        public HTableCell GetCell(string targetColumn, string uniqueValue, string columnName)
        {
            return GetCell(targetColumn, uniqueValue, _columns.IndexOf(columnName));
        }

        public HTableCell GetCell(string targetColumn, string uniqueValue, int columnIndex)
        {
            HTableRow tableRow = GetRow(targetColumn, uniqueValue);
            return tableRow.GetCell(columnIndex);
        }

        public HTableRow GetRow(string targetColumn, string uniqueValue)
        {
            foreach (var row in _rows)
            {
                if (row.GetCell(_columns.IndexOf(targetColumn)).Text.Equals(uniqueValue))
                {
                    return row;
                }
            }

            return null;
        }

        public List<string> GetValues(string targetColumn)
        {
            List<string> result = new List<string>();

            foreach (var row in _rows)
            {
                result.Add(row.GetCell(_columns.IndexOf(targetColumn)).Text);
            }

            return result;
        }

        public void EditRow(string targetColumn, string uniqueValue)
        {
            HTableRow tableRow = GetRow(targetColumn, uniqueValue);
            tableRow.GetCell(_columns.IndexOf("Action")).GetEditLink().Click();
        }

        public void DeleteRow(string targetColumn, string uniqueValue)
        {
            HTableRow tableRow = GetRow(targetColumn, uniqueValue);
            tableRow.GetCell(_columns.IndexOf("Action")).GetDeleteLink().Click();
        }
    }
}
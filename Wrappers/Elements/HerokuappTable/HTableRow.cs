using OpenQA.Selenium;

namespace Wrappers.Elements.HerokuappTable
{
    public class HTableRow
    {
        private UIElement _uiElement;
        private List<HTableCell> _cells;

        public HTableRow(UIElement uiElement)
        {
            _uiElement = uiElement;
            _cells = new List<HTableCell>();

            foreach (var cellElement in _uiElement.FindUIElements(By.TagName("td")))
            {
                _cells.Add(new HTableCell(cellElement));
            }
        }

        public HTableCell GetCell(int columnIndex)
        {
            return _cells[columnIndex];
        }
    }
}
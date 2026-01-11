using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Hosting;

namespace Pivot
{
    public partial class PivotTest1 : Windows.UI.Xaml.Controls.Pivot
    {
        public PivotTest1()
        {
            var test = ElementCompositionPreview.GetElementVisual(this);
        }
    }
}

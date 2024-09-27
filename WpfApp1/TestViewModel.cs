using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1;
public partial class TestViewModel : INotifyPropertyChanged
{
    public string SampleProp { get; set; } = "Sample";

}
